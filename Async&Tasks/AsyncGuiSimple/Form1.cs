namespace AsyncGuiSimple {

    public partial class Form1 : Form {

        private readonly int sleepMs = 8000;
        private int dumbSum;

        public Form1() {
            InitializeComponent();
        }

        private void DisplayPictureBox(PictureBox pb, string imagePath) {
            Bitmap img = new Bitmap(imagePath);
            pictureBox1.Image = img;
        }
        private void BtnSync_Click(object sender, EventArgs e) {
            ChangeButtonStatus(btnSync, false);
            lblReady.Text = String.Empty;
            // Display immediately
            this.lblBtnWasPressed.Text = GetTimeNowString() + " - " + ((Button)sender).Name + " was pressed";
            this.lblBtnWasPressed.Refresh();
            this.lblReady.Text = "Job processing!";
            // Do some work synchronously - blocks GUI
            string res = DoWork();
            DisplayPictureBox(pictureBox1, @"C:\Users\thoma\Pictures\UP process 2.jpg");
            this.lblReady.Text = GetTimeNowString() + " - " + res;
            ChangeButtonStatus(btnSync, true);
        }

        private async void BtnAsync_Click(object sender, EventArgs e) {
            ChangeButtonStatus(btnAsync, false);
            lblReady.Text = String.Empty;
            // Display immediately
            this.lblBtnWasPressed.Text = GetTimeNowString() + " - " + ((Button)sender).Name + " was pressed";
            this.lblReady.Text = "Job processing!";
            // Do some work asynchronously
            string res = await DoWorkAsync();
            this.lblReady.Text = GetTimeNowString() + " - " + res;
            ChangeButtonStatus(btnAsync, true);
        }

        private void BtnIncrement_Click(object sender, EventArgs e) {
            dumbSum++;
            lblIncrement.Text = dumbSum.ToString();
        }

        private string DoWork() {
            Thread.Sleep(sleepMs);
            return "Job done!";
        }


        private async Task<string> DoWorkAsync() {

            return await Task.Run(() => {
                Thread.Sleep(sleepMs);
                return "Job Done!";
            });

        }
        //private Task<string> DoWorkAsync() {
        //    Task<string> foundRes = Task.Run(
        //        () => {
        //        Thread.Sleep(sleepMs);
        //        return "Job Done!";
        //    });

        //    return foundRes;
        //}

        private string GetTimeNowString() {
            TimeSpan startTime = DateTime.Now.TimeOfDay;
            string startStr = $"{startTime.Minutes}:{startTime.Seconds}:{startTime.Milliseconds}";
            return startStr;
        }

        private void ChangeButtonStatus(Button btnToManage, bool setActive) {
            btnToManage.Enabled = setActive;
        }

    }
}
