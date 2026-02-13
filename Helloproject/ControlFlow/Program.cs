// See https://aka.ms/new-console-template for more information

using ControlFlow.Business;
using ControlFlow.Model;

Employee e1 = new Employee("John Doe", new DateTime(2020, 1, 1), JobTitle.CEO);
Employee e2 = new Employee("Jane Smith", new DateTime(2019, 5, 1), JobTitle.Unknown);
Employee e3 = new Employee("Bob Johnson", new DateTime(2021, 3, 15), JobTitle.Manager);
Employee e4 = new Employee("Thomas Murray", new DateTime(2025, 1, 1), JobTitle.Developer);

Salary salary = new Salary();
int e1Salary = salary.CalculateSalary(e1.JobTitle);
int e2Salary = salary.CalculateSalary(e2.JobTitle);
int e3Salary = salary.CalculateSalary(e3.JobTitle);
int e4Salary = salary.CalculateSalary(e4.JobTitle);

Console.WriteLine(e1);
Console.WriteLine($"Salary: {e1Salary}" + Environment.NewLine);

Console.WriteLine(e2);
Console.WriteLine($"Salary: {e2Salary}" + Environment.NewLine);

Console.WriteLine(e3);
Console.WriteLine($"Salary: {e3Salary}" + Environment.NewLine);

Console.WriteLine(e4);
Console.WriteLine($"Salary: {e4Salary}" + Environment.NewLine);



