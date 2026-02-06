// See https://aka.ms/new-console-template for more information
using ObjectInitialization.Model;

Console.WriteLine("Hello, World!");

Person p1 = new Person();
Person p2 = new Person("Thomas Murray");
Person p3 = new Person("Jens Jensen" + new DateTime(1999, 8, 31));

Console.WriteLine("Name: " + p1.Name);
Console.WriteLine("Name: " + p2.Name);
Console.WriteLine("Name: " + p3.Name + " ");


