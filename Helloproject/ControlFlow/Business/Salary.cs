using ControlFlow.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ControlFlow.Business
{
    public class Salary
    {
        public int CalculateSalary(JobTitle jobTitle)
        {
            return (jobTitle) switch
            {
                JobTitle.CEO => 120000,
                JobTitle.CTO => 100000,
                JobTitle.Manager => 75000,
                JobTitle.Developer => 55000,
                JobTitle.Designer => 35000,
                JobTitle.Tester => 35000,
                _ => 0
            };
        }
    }
}
