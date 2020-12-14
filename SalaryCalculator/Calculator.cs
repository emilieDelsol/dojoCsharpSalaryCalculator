using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator
{
    public class Calculator
    {
        public ICollection<Company> Companies { get; set; }

        public Calculator()
        {
            Companies = new List<Company>();
        }

        public double TotalCompaniesExpenditures
        { 
            get
            {
                throw new NotImplementedException();
            }
        }

    }
}
