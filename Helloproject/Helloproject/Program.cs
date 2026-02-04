// See https://aka.ms/new-console-template for more information
using Helloproject.Data;
using System;

Console.WriteLine("Hello, World!");

Student aStudent = new Student()
{
    FirstName = "Hans",
    LastName = "Hansen",
    YearOfBirth = 1966
}
;

Console.WriteLine("Hello " + aStudent.HelloName);
