// See https://aka.ms/new-console-template for more information
using StudentList.Data;

Console.WriteLine("Hello, World!");

Student studentlist = new Student()
{
    FirstName = "Thomas",
    LastName = "Murray",
    YearOfBirth = 1999
};

foreach (string? s in studentlist.Students)
{
    if (!string.IsNullOrEmpty(s))
    {
        studentlist.Students.Add(s);
    }
}