// See https://aka.ms/new-console-template for more information
using StudentList.Data;
using System.Linq;

Console.WriteLine("Hello, World!");

Student stu = new Student()
{
    FirstName = "Thomas",
    LastName = "Murray",
    YearOfBirth = 1999
};

if (stu.Students == null || stu.Students.Any())
{
    Console.WriteLine("The List is empty");
}
else
{
    int validCount = 0;

    foreach (string? s in stu.Students)
    {
        if (string.IsNullOrWhiteSpace(s))
        {
            continue;
        }

        Console.WriteLine(s);
        validCount++;
    }

    if (validCount == 0)
    {
        Console.WriteLine("Sorry - no input found");
    }
}


Console.WriteLine(stu.Students.Any()
    );


