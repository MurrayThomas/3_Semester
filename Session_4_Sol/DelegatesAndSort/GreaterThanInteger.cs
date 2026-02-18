namespace DelegatesAndSort;

// IComparer<T> Interface
// https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.icomparer-1?view=net-10.0
public class GreaterThanInteger : IComparer<int> {

    public int Compare(int x, int y) {
        return (x - y);
    }

}