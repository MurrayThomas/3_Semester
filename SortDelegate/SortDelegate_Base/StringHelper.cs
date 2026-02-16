using System.Text;

namespace SortDelegate_Base {
    internal class StringHelper {

        static readonly char delimiter = '-';

        public static string GetDisplayString(IEnumerable<int> nums) {
            StringBuilder sb = new StringBuilder();

            foreach (int sco in nums) {
                sb.Append(delimiter.ToString() + sco);
            }

            return sb.ToString();
        }

    }
}
