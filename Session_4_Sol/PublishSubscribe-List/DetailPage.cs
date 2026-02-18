using PublishSubscribe_List.Model;
using System.ComponentModel;

namespace PublishSubscribe_List {
    public partial class DetailPage : Form {

        // 1. and 2.
        public EventHandler<PersonEventArgs> NameInput;

        ListPage _subscriberForm;

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<int> IdleIds { get; set; }

        public DetailPage(ListPage prevPage, List<int> ids) {
            InitializeComponent();

            _subscriberForm = prevPage;
            prevPage.Hide();

            IdleIds = ids;
            PopulateIdControl();
        }

        private void BtnOk_Click(object sender, EventArgs e) {
            string firstName = tbFirst.Text;
            string lastName = tbLast.Text;
            if (!string.IsNullOrWhiteSpace(firstName) && !string.IsNullOrWhiteSpace(lastName) && (dropdownIds.SelectedItem != null || dropdownIds.Text != null)) {
                int foundId; //= (int)dropdownIds.SelectedItem;
                bool isInt = int.TryParse(dropdownIds.Text, out foundId);
                if (isInt) {
                    Person aPerson = new Person(foundId, firstName, lastName);
                    OnNameInput(aPerson);
                    _subscriberForm.Show();
                } else {
                    MessageBox.Show("Id must be a number!", "Sorry, but ..");
                }
            }
            else {
                MessageBox.Show("Input is missing!", "Sorry, but ..");
            }
        }

        // 3. Raise an event - if any subscribers
        protected virtual void OnNameInput(Person inPerson) {
            //if (NameInput != null) {
            //    NameInput(this, new PersonEventArgs() { Person = inPerson });
            //}
            // Shorthand for the above  
            NameInput?.Invoke(this, new PersonEventArgs() { Person = inPerson });
        }

        private void PopulateIdControl() {
            foreach (int id in IdleIds) {
                dropdownIds.Items.Add(id);
            }
        }

        private void OnClose(object sender, FormClosedEventArgs e) {
            _subscriberForm.Show();
        }

    }
}
