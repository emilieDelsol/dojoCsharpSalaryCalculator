using System;

namespace SalaryCalculator
{
    public class Employee
    {
        public String Name { get; set; }
        public Double HourlySalary { get; set; }
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
    }
}
