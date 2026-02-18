using System.Text;

namespace DelegatesAndSort {
    internal class StringHelper {

        static readonly char _delimiter = '-';

        // Display with header
        public static string GetDisplayString(string headLine, IEnumerable<int> numbers) {
            string sb = "-- " + headLine + " --" + Environment.NewLine;
            sb += GetNumberString(numbers);
            sb += Environment.NewLine;
            return sb;
        }

        // Avoid the prefix hyphen
        private static string GetNumberString(IEnumerable<int> nums) {
            StringBuilder sb = new StringBuilder();
            bool isFirst = true;
            foreach (int num in nums) {
                if (isFirst) {
                    sb.Append(num);
                    isFirst = false;
                } else {
                    sb.Append(_delimiter.ToString() + num);
                }
            }
            return sb.ToString();
        }

    }
}
