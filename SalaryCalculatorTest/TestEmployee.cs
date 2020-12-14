using NUnit.Framework;
using SalaryCalculator;

namespace SalaryCalculatorTest
{
    public class TestEmployee
    {
        [Test]
        public void TestEmployeeWeeklySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };
            Assert.AreEqual(350.0d, employee.WeeklySalary,
                            "An employee that works 35 hours a week paid 10.0 $ an hour must be paid 350.0 $ per week");
        }

        [Test]
        public void TestEmployeeDailySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };
            Assert.AreEqual(70.0d, employee.DailySalary,
                            "An employee that works 35 hours a week paid 10.0 $ an hour must be paid 70.0 $ per day");
        }
        
        [Test]
        public void TestEmployeeMonthlySalary()
        {
            Employee employee = new Employee { Name = "Test", HourlySalary = 10.0d, WeekTimePeriodWorked = 35 };
            Assert.AreEqual(1400.0d, employee.DailySalary,
                            "An employee that works 35 hours a week paid 10.0 $ an hour must be paid 1400.0 $ per month");
        }
    }
}