
namespace PublishSubscribe_Data;
public partial class PublisherForm : Form {

    // Methods with parameters(object sender, NameChangedEventArgs ncEventArgs) can be associated to the delegate
    public event EventHandler<NameChangedEventArgs> NameInput;

    SubscriberForm _subscriberForm;

    public PublisherForm(SubscriberForm prevPage) {
        InitializeComponent();

        _subscriberForm = prevPage;
        prevPage.Hide();
    }

    private void BtnOk_Click(object sender, EventArgs e) {
        string firstName = null, lastName = null;
        if (!string.IsNullOrEmpty(this.tbFirstname.Text)) {
            firstName = this.tbFirstname.Text;
        }
        if (!string.IsNullOrEmpty(this.tbLastname.Text)) {
            lastName = this.tbLastname.Text;
        }
        if (firstName != null && lastName != null) {
            // call OnNameInput method to raise event
            OnNameInput(firstName, lastName);
            _subscriberForm.Show();
        } else {
            MessageBox.Show("Input is missing!", "Sorry, but ..");
        }
    }

    protected virtual void OnNameInput(string fName, string lName) {
        NameChangedEventArgs nameChangedEventArgs = new NameChangedEventArgs(fName, lName);
        if (NameInput != null) {
            NameInput(this, nameChangedEventArgs);
        }
        /* Two other syntaxes for calling the associated eventhandlers */
        //if (NameInput != null && NameInput.GetInvocationList().Count() > 0) {
        //    NameInput.Invoke(this, nameChangedEventArgs);
        //}
        //
        //NameInput?.Invoke(this, nameChangedEventArgs);
    }

    private void OnClose(object sender, FormClosedEventArgs e) {

    }

}