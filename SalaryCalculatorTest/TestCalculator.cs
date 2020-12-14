using NUnit.Framework;
using SalaryCalculator;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculatorTest
{
    public class TestCalculator
    {
        [Test]
        public void TestTotalCompaniesExpenditures()
        {
            Calculator calculator = new Calculator
            {
                Companies = new List<Company>
                {
                    new Company { Name = "Test1", Employees = new List<Employee>
                        {
                            new Employee { Name = "Test", HourlySalary = 10, WeekTimePeriodWorked = 35 },
                            new Employee { Name = "Test", HourlySalary = 10, WeekTimePeriodWorked = 35 }
                        }
                    },
                    new Company { Name = "Test2", Employees = new List<Employee>
                        {
                            new Employee { Name = "Test", HourlySalary = 10, WeekTimePeriodWorked = 35 },
                            new Employee { Name = "Test", HourlySalary = 10, WeekTimePeriodWorked = 35 }
                        }
                    },
                }
            };
            Assert.AreEqual(2800, calculator.TotalCompaniesExpenditures);
        }
    }
}
