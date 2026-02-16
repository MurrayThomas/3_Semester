namespace SortDelegate_Base;
static class DelegateBubleSort {

    // Delegate - notice parameters and return type
    public delegate bool CompareTwo(int first, int second);

    // BubleSort with Delegate parameter (code that governs the comparison of two int values)
    public static void BubbleSort(int[] items, CompareTwo compareHandler) {
        int i, j, temp;

        if (items != null) {

            for (i = items.Length - 1; i >= 0; i--) {
                for (j = 1; j <= i; j++) {
                    if (compareHandler(items[j - 1], items[j])) {
                        temp = items[j - 1];
                        items[j - 1] = items[j];
                        items[j] = temp;
                    }
                }
            }
        }// ends if
    }

    // Sort order - in ascending order
    public static bool GreaterThan(int first, int second) {
        bool isGreater = (first > second);
        return isGreater;
    }

    // Sort order - in ascending alphabetic order
    /*
     * Your code here
     */

    // Sort order - even values before odd values
    /*
     * Your code here
     */

    // Sort order - even values in ascending order, then odd values in ascending order
    /*
     * Your code here
     */

}
