// See https://aka.ms/new-console-template for more information
using ObjectInitialization.Model;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

Person p1 = new Person();
Person p2 = new Person("Jens Jensen");
Person p3 = new Person("Thomas Murray " + new DateTime(1999, 8, 31, 5, 32, 0));
//Person p4 = new Person()
//{
//    Name = "Thomas",
//    Birthdate = new DateTime(1999, 8, 31, 5, 32, 0)
//};

//Console.WriteLine("Name: " + p1.Name);
//Console.WriteLine("Name: " + p2.Name);
Console.WriteLine("Name: " + p3.Name + " ");
//Console.WriteLine(p4);

Console.WriteLine("------------------");
Employee employee1 = new Employee("Hans Hansen", new DateTime(1995, 6, 21), 25000, 1);
Console.WriteLine(employee1);

Company company1 = new Company(123);
Console.WriteLine("Company name: ");
Console.WriteLine(company1);