namespace DelegatesAndSort;

static class DelegateBubleSort {

    // Delegate - notice parameters and return type
    public delegate bool CompareTwo(int first, int second);

    // BubleSort with Delegate parameter (code that governs the comparison of two int values)
    public static void BubbleSort(int[] items, CompareTwo compareHandler) {
    // public static void BubbleSort(int[] items, Func<int, int, bool> compareHandler) {
    
        int i, j, temp;

        if (items != null) {

            for (i = items.Length - 1; i >= 0; i--) {
                for (j = 1; j <= i; j++) {
                    if (compareHandler(items[j - 1], items[j])) {   // delegate applied and run
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

    // 2. Sort order - in ascending alphabetic order
    /*
     * Two versions:
     * Easiest to understand: AlphabeticGreaterThan
     * Shortest: AlphabeticGreaterThan2
     * Pseudocode for first version:
     * 1. string 1 and string 2 - convert first and second int values to string values
     * 2. compare the string values
     * 3. evaluate
     * 4. return evaluation result
    */
    public static bool AlphabeticGreaterThan(int first, int second) {
        bool isGreater = false;
        // 1.convert first and second int values to string values
        string firstStr = first.ToString();
        string secondStr = second.ToString();
        // 2.compare the string values
        int comparison = firstStr.CompareTo(secondStr);
        // 3.evaluate
        if (comparison > 0) {
            isGreater = true;
        }
        // 4. return evaluation result
        return isGreater;
    }
    // Shorter version
    public static bool AlphabeticGreaterThan2(int first, int second) {
        int compareVal = first.ToString().CompareTo(second.ToString());
        return (compareVal > 0);
    }

    // 3. Sort order - even values before odd values
    public static bool EvenBeforeOdd(int first, int second) {
        bool foundBool = true;
        if (first % 2 == 0) {
            foundBool = false;
        }
        // Shorter version:
        //bool foundBool = (first % 2 > second % 2);
        return foundBool;
    }

    // 4. Sort order - even and ascending, then odd and ascending
    /*
     * Two versions:
     * Easiest to understand: EvenOddGreater
     * Shortest: EvenOddGreater2
     * Pseudocode for first version:
     * 1. calculate remainder for first and second int values
     * 2. compare the remainder values
     * 2a. If different (one even and one odd)
     *    Evaluate and get result (based on even / odd) 
     * 2b. Else (both even or both odd)
     *    Evaluate and get result based on which is greatest 
    */
    public static bool EvenBeforeOddAscending(int first, int second) {
        bool isGreater = false;
        // 1.calculate remainder for first and second int values
        int remainderFirst = first % 2;
        int remainderSecond = second % 2;
        // 2.compare the remainder values
        bool isDifferent = (remainderFirst != remainderSecond);
        // 2a.If different(one even and one odd)
        //   Evaluate and get result(based on even / odd)
        if (isDifferent) {
            if (remainderFirst == 1) {
                isGreater = true;
            }
        } else {
            // 2b.Else(both even or both odd)
            //   Evaluate and get result based on which is greatest
            isGreater = (first > second);
        }
        return isGreater;
    }
    // Shorter version
    public static bool EvenBeforeOddAscending2(int first, int second) {
        int comparison = (first % 2) - (second % 2);
        if (comparison == 0) {
            comparison = first - second;
        }
        bool isGreater = (comparison > 0);

        return isGreater;
    }

    // Returns int
    public static int EvenBeforeOddAscending3(int first, int second) {

        int comparison = (first % 2) - (second % 2);
        if (comparison == 0) {
            comparison = first - second;
        }

        return comparison;
    }

}
