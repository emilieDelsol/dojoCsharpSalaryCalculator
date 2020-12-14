using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalaryCalculator
{
    public class Company
    {
        public String Name { get; set; }
        public ICollection<Employee> Employees { get; set; }

        /// <summary>
        /// Total of employees salary per month
        /// </summary>
        public Double MonthlySalaryExpenditures 
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Total of employees salary per year
        /// </summary>
        public Double YearlySalaryExpenditures 
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
