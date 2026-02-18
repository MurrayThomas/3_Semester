using DelegatesSortGui.Model;

namespace DelegatesSortGui.Data {
    public class GamerData {

        readonly List<Gamer> _gamers;

        public GamerData() {
            _gamers = new List<Gamer>();
        }

        public List<Gamer> FetchGamers() {

            _gamers.Add(new Gamer(1, "SuperHero", 759120));
            _gamers.Add(new Gamer(2, "Xyp9x", 3947630));
            _gamers.Add(new Gamer(3, "dupreeh", 9959570));

            return _gamers;
        }
    }
}
