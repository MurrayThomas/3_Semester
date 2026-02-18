using PublishSubscribe_List.Model;

/* I update the ListView control manually which is the most understandable
 * Alternatively you could update automatically by using BindingList 
 * and atoher type of control - but it becomes quite abstract then.
 * LRL
 */

namespace PublishSubscribe_List {

    public partial class ListPage : Form {

        DetailPage _inputPage;
        List<Person> _persons;

        public ListPage() {
            InitializeComponent();

            if (_persons == null) {
                _persons = new List<Person>();
            }

        }

        private void BtnGotoNamePage_Click(object sender, EventArgs e) {
            List<int> indleIds = GetIdleIds();

            _inputPage = new DetailPage(this, indleIds);        // Publisher
            // Subscribe - add event handler to event NameInput invocation list
            _inputPage.NameInput += this.OnNameWasEntered;

            _inputPage.Show();
        }

        // A subscriber - Event Handler
        public void OnNameWasEntered(object source, PersonEventArgs pE) {
            //
            _persons.Add(pE.Person);

            ListViewItem personItem = new ListViewItem {
                Text = pE.Person.ToString(),
                Tag = pE
            };
            lvPersons.Items.Add(personItem);

            // Display nice header
            string personText = _persons.Count > 1 ? "persons" : "person";
            lblHeadline.Text = $"List of {_persons.Count} {personText}";
        }

        private void OnVisible(object sender, EventArgs e) {
            if (this.Visible && _inputPage != null) {
                _inputPage.Hide();
            }
        }

        // Can be used if you want to edit a person (on an edit page)
        private void LvPersons_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e) {
            PersonEventArgs selPerson = e.Item.Tag as PersonEventArgs;
            Person selectedPerson = selPerson.Person;
            lblNote.Text = $"{selPerson.Person.FirstName} {selectedPerson.LastName} was selected!";
        }

        // Find id number not currently used
        private List<int> GetIdleIds() {
            int wantedNumberOfIds = 10;
            List<int> foundIds = new List<int>();
            int testId = 1;
            while (foundIds.Count <= wantedNumberOfIds) {
                bool isIdle = true;
                foreach (Person per in _persons) {
                    if (per.Id == testId) {
                        isIdle = false;
                    }
                }
                if (isIdle) {
                    foundIds.Add(testId);
                }
                testId++;
            }
            return foundIds;
        }

    }
}
