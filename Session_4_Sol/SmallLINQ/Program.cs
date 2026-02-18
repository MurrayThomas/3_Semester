/* SOLS to Exercise_LINQ
 * Uses LINQ and lambda
 * LINQ is a language-integrated query framework implemented through compiler features and .NET libraries.
 */

IEnumerable<string> names = new List<string> { "Loa", "Hans", "Marianne", "Harry"};
IEnumerable<string> names2 = ["Loa", "Hans", "Marianne", "Harry"];      // alt. newer syntax
// Console.WriteLine(names.GetType().FullName);
// Console.WriteLine(names2.GetType().FullName);


/* 1. Create a method that returns all names of length 4 or more.
 * 2. Create a method that returns all names containing an ‘a’. 
 *    The names must be sorted by length and be in upper case.
 */

// 1. - All names of length 4 or more
int minNameLength = 4;
IEnumerable<string> longNames = GetLongNames(names, minNameLength);
Console.WriteLine("Long names:");
Display(longNames);

// 2. - All a names - names must be presented sorted by length and in upper case
string letterStr = "a";
char letterInUpperCase = letterStr.ToUpper().ToCharArray()[0];
IEnumerable<string> specialNames = GetWithLetterNamesSortedUpper(names, letterInUpperCase);
Console.WriteLine(Environment.NewLine + "Names with " + letterStr);
Display(specialNames);


// 1 - GetLongNames
IEnumerable<string> GetLongNames(IEnumerable<string> testColl, int minLen) {

    IEnumerable<string> filteredNames = testColl.Where((string str) => str.Length >= minLen);
    return filteredNames;

}

// 2 - GetWithLetterNamesSortedUpper
IEnumerable<string> GetWithLetterNamesSortedUpper(IEnumerable<string> testColl, char targetLetterUpper) {

    IEnumerable<string> filteredNames = testColl
        .Select(str => str.ToUpper())
        .Where(str => str.Contains(targetLetterUpper))
        .OrderBy(str => str.Length);
    return filteredNames;

}


void Display(IEnumerable<string> strings) {
    foreach (string str in strings) {
        Console.WriteLine(str);
    }
}

Console.WriteLine();
Console.WriteLine("Extra: work with numbers");
/* Demo */
IEnumerable<int> scores = [67, 5, 12, 94, 23, 81, 56, 38, 15, 72, 43, 8];

// Find greatest score - ver 1
int max = int.MinValue;
foreach (int num in scores) {
    if (num > max) {
        max = num;
    }
}
Console.WriteLine("Max Score = " + max);

// Find greatest score - ver 2
// Use of Enumerable.Max Method from Namespace: System.Linq
int max2 = scores.Max();
//int max2 = scores.Max(num => num);
Console.WriteLine("Max Score = " + max2);

// Find average score
double avg = scores.Average();
Console.WriteLine($"Average score = {avg}");
Console.WriteLine($"Average score = {Math.Round(avg, 2)}");