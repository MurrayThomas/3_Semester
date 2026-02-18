
using DelegatesSortGui.Model;

namespace DelegatesSortGui.Data {
    public class GamerOrder {

        static bool currentHighScoreOrderIsAscending = false;
        static bool currentNameOrderIsAscending = false;

        // Toggles to opposite order
        public static void ToogleCurrentNameOrderIsAscending() {
            currentNameOrderIsAscending = !currentNameOrderIsAscending;
        }
        public static void ToogleCurrentHighScoreOrderIsAscending() {
            currentHighScoreOrderIsAscending = !currentHighScoreOrderIsAscending;
        }

        // Order by name
        public static int OrderByName(Gamer x1, Gamer x2) {
            int compInt = 0;
            if (x2 == null) {
                compInt = -1;
            } else {
                if (x1.NickName.CompareTo(x2.NickName) > 0) compInt = -1;
                if (x1.NickName.CompareTo(x2.NickName) < 0) compInt = 1;
            }
            if (currentNameOrderIsAscending) {
                compInt *= -1;
            }
            return compInt;
        }

        // order by high score
        public static int OrderByHighScore(Gamer x1, Gamer x2) {
            int compInt = 0;
            if (x2 == null) {
                compInt = -1;
            } else {
                if (x1.HighScore.CompareTo(x2.HighScore) > 0) compInt = -1;
                if (x1.HighScore.CompareTo(x2.HighScore) < 0) compInt = 1;
            }
            if (currentHighScoreOrderIsAscending) {
                compInt *= -1;
            }
            return compInt;
        }

    }
}