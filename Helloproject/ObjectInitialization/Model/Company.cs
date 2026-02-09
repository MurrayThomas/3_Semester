using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectInitialization.Model
{
    public class Company(int companyNo)
    {
        public int companyNo { get; set; } = companyNo;

        public override string? ToString()
        {
                return $"CompanyNo: {companyNo}";
        }
    }
}
