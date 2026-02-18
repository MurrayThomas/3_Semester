
namespace PublishSubscribe_Data;

// Defines custom EventArgs
public class NameChangedEventArgs : EventArgs {

    public NameChangedEventArgs(string inFirstName, string inLastName) {
        FirstName = inFirstName;
        LastName = inLastName;
    }

    public string FirstName { get; init; }
    public string LastName { get; init; }

}
