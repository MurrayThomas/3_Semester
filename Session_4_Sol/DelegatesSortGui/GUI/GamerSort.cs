using DelegatesSortGui.Data;
using DelegatesSortGui.Model;

namespace DelegatesSortGui {
    public partial class GamerSort : Form {

        List<Gamer>? _foundGamers;

        public GamerSort() {
            InitializeComponent();
        }

        private void GamerSort_Load(object sender, EventArgs e) {
            GamerData gd = new GamerData();
            _foundGamers = gd.FetchGamers();

            UpdateGamerListBox();
        }

        private void BtnByName_Click(object sender, EventArgs e) {
            GamerOrder.ToogleCurrentNameOrderIsAscending();
            if (_foundGamers != null ) {
                _foundGamers.Sort(GamerOrder.OrderByName);
            }
            //// Possibly use: null-conditional operator
            //_foundGamers?.Sort(GamerOrder.OrderByName);
            UpdateGamerListBox();
        }

        private void BtnByHighScore_Click(object sender, EventArgs e) {
            GamerOrder.ToogleCurrentHighScoreOrderIsAscending();
            if (_foundGamers != null ) {
                _foundGamers.Sort(GamerOrder.OrderByHighScore);
            }
            //_foundGamers?.Sort(GamerOrder.OrderByHighScore);
            UpdateGamerListBox();
        }

        // Populate ListBox control
        private void UpdateGamerListBox() {
            lbGamers.Items.Clear();     // reset
            if (_foundGamers != null) {
                foreach (Gamer gmr in _foundGamers) {
                    lbGamers.Items.Add(gmr);
                }
            }
        }

    }
}