using DelegatesAndSort;


int[] scores = [4, 2, 7, 4, 9, 13, 2, 1, 4, 0, 5];

string header;

// Display scores as entered in collection
header = "Unsorted scores";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));

/* 1 */
// Display scores sorted ascending
// Use BubleSort method - member og DelegateBubleSort class 
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.GreaterThan);
header = "1. Sorted scores";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));

/* 2 */
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.AlphabeticGreaterThan);
header = "2. Sorted AlphabeticGreaterThan";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));

/* 3 */
// Display scores even before odd
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.EvenBeforeOdd);
header = "3. Sorted scores - even first";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));

/* 4 */
// Display scores even before odd - and ascending
DelegateBubleSort.BubbleSort(scores, DelegateBubleSort.EvenBeforeOddAscending);
header = "4. Sorted scores - even first - and ascending";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));


Console.WriteLine("---------------------------------------" + Environment.NewLine);

/* Lambda - anonymous method */
// Display scores sorted descending
DelegateBubleSort.BubbleSort(scores, (int x, int y) => x < y);
header = "Sorted scores - descending (with lambda)";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));


Console.WriteLine("---------------------------------------" + Environment.NewLine);

Console.WriteLine("Sort scores - Challenge - some solutions" + Environment.NewLine);
/* Use std. Array Sort method */
/* Based on: 
* Comparison<T> Delegate
* Represents methods that compares two objects of the some type - and return an int
* public delegate int Comparison<in T>(T x, T y);
*                            The in keyword causes arguments to be passed by reference but ensures the argument is not modified
*/

/* 1 - alternative */
Array.Sort(scores, DelegateBubleSort.EvenBeforeOddAscending3);
header = "Sorted GreaterThan using standard Sort() - by method that complies with delegate";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));

/* 2 - alternative */
IComparer<int> compareClass = new GreaterThanInteger();     // Class that implements IComparer
Comparison<int> compareMethod = compareClass.Compare;
Array.Sort(scores, compareMethod);
header = "Sorted GreaterThan using standard Sort() - by class that implements IComparer";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));

/* 3 - alternative */
Array.Sort(scores, (int first, int second) => {
    int numComp = (second % 2) - (first % 2);
    if (numComp == 0) {
        numComp = second - first;
    }
    return numComp;
});
header = "Sorted OddEvenLesser using standard Sort() and Lambda expression";
Console.WriteLine(StringHelper.GetDisplayString(header, scores));


Console.Read();