namespace PublishSubscribe_Data;
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

    // Event handles complies with delegate EventHandler<NameChangedEventArgs>
    void NameInputEventHandler(object sender, NameChangedEventArgs nameChangedData) {
        lblName.Text = $"{nameChangedData.FirstName} {nameChangedData.LastName}";
    }

    private void OnVisible(object sender, EventArgs e) {
        if (inputPage != null) {
            inputPage.Hide();
        }
    }

}