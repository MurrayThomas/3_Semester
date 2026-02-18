namespace PublishSubscribe_Notify {
    public partial class PublisherForm : Form {

        // 1. Define a delegate
        // NameInputEventHandler delegate goes here

        // 2. Define an event based on the delegate
        // NameInput event goes here

        // 1. and 2.
        public event EventHandler NameInput;
        // EventHandler - Defines the Delegate (method signature) that event handlers must match.
        // EventHandler is a delegate type.
        // EventHandler is a predefined delegate in C#:   https://learn.microsoft.com/en-us/dotnet/api/system.eventhandler?view=net-10.0
        //                  void EventHandler(object? sender, EventArgs e);

        private readonly SubscriberForm _subscriberForm;

        public PublisherForm(SubscriberForm prevPage) {
            InitializeComponent();

            _subscriberForm = prevPage;
            prevPage.Hide();
        }

        private void BtnOk_Click(object sender, EventArgs e) {
            if (!string.IsNullOrWhiteSpace(this.tbName.Text)) {
                // call OnNameInput method to raise event
                OnNameInput();
                _subscriberForm.Show();
            } else {
                MessageBox.Show("Input is missing!", "Sorry, but ..");
            }
        }

        // 3. Raise an event - if any subscribers
        protected virtual void OnNameInput() {
            //
            if (NameInput != null) {
                // The methods in the invocation list are called
                NameInput.Invoke(this, EventArgs.Empty);
                //NameInput(this, EventArgs.Empty);       // Shorter
            }
            //// Possible use null-conditional operator
            //NameInput?.Invoke(this, EventArgs.Empty);
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            _subscriberForm.Show();
        }

    }
}