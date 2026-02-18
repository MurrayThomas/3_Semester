namespace PublishSubscribe_Notify;

public partial class SubscriberForm : Form {

    PublisherForm inputPage;

    public SubscriberForm() {
        InitializeComponent();
    }

    private void BtnGotoNamePage_Click(object sender, EventArgs e) {
        inputPage = new PublisherForm(this);
        // Subscribe - add event handler to event NameInput invocation list
        inputPage.NameInput += NameInputEventHandler;
        inputPage.Show();
    }

    void NameInputEventHandler(object sender, EventArgs e) {
        lblName.Text = "Thank you for entering a name!";
    }

    private void OnVisible(object sender, EventArgs e) {
        if (inputPage != null) {
            inputPage.Hide();
        }
    }
}