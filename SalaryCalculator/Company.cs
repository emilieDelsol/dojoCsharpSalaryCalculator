using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculator
{
    public class Company
    {
        public String Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

        public Double MonthlySalaryExpenditures 
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
