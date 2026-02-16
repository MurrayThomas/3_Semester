using ControlFlow.Business;
using ControlFlow.Model;
using Xunit;

namespace TestProject
{
    public class SalaryTests
    {
        [Fact]
        public void TestStandardSalaryForDeveloper()
        {
            // Arrange
            int expectedSalary = 55000;
            DateTime startDt1 = new DateTime(1992, 9, 21);
            Employee empl = new Employee("Donald Duck", startDt1, JobTitle.Developer);
            Salary salary = new Salary();

            // Act
            int foundSalary = salary.CalculateSalary(JobTitle.Developer);

            // Assert
            Assert.Equal(expectedSalary, foundSalary);

        }

        //private static int GetSeniorityYears(DateTime startDate)
        //{
        //    // Neutralize time of day and get difference span of years
        //    DateTime nowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        //    int senYears = nowDate.Year - startDate.Year;

        //    // Neutralize year and get difference in days
        //    DateTime modifiedStartDate = new DateTime(DateTime.Now.Year, startDate.Month, startDate.Day);
        //    TimeSpan startMinusNow = modifiedStartDate - nowDate;
        //    int yearDayDifference = startMinusNow.Days;

        //    // If startdate later in year than now - then substract 1 year
        //    if (yearDayDifference > 0)
        //    {
        //        senYears -= 1;
        //    }
        //    return senYears;
        //}
    }
}
