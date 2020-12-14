using System;

namespace SalaryCalculator
{
    public class Employee
    {
        public String Name { get; set; }
        public Double HourlySalary { get; set; }
        /// <summary>
        /// Period of hours worked in one week
        /// </summary>
        public Int32 WeekTimePeriodWorked { get; set; }

        public Double WeeklySalary
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Double DailySalary
        {
            get 
            {
                throw new NotImplementedException();
            }
        }

        public double MonthlySalary 
        { 
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
