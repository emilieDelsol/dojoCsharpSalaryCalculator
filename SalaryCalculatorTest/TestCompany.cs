using NUnit.Framework;
using SalaryCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorTest
{
    public class TestCompany
    {
        [Test]
        public void TestZeroSalaryCompany()
        {
            Company company = new Company { Name = "Test" };
            Assert.AreEqual(0, company.MonthlySalaryExpenditures, 
                            "A company with no employees should have no salary expenditures");
        }
        
        [Test]
        public void TestCompanyWithEmployees()
        {
            Company company = new Company { Name = "Test" };
            company.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Assert.AreEqual(2000, company.MonthlySalaryExpenditures,
                            "A company with two salaries equals to 1000 $ should spend 2000 $"); 
        }

        [Test]
        public void TestCompanyWithEmployeesYearly()
        {
            Company company = new Company { Name = "Test" };
            company.Employees = new List<Employee>
            {
                new Employee { Name = "Test1", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 },
                new Employee { Name = "Test2", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 }
            };
            Assert.AreEqual(1800.0, company.MonthlySalaryExpenditures,
                            "A company with two salaries equals to 1000 $ should spend 24 000 $ yearly");
        }
    }
}
