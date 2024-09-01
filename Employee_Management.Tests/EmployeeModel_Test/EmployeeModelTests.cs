using Employee_Management.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Employee_Management.Tests.EmployeeModel_Test
{
    [TestClass]
    public class EmployeeModelTests
    {
        [TestMethod]
        public void Employee_ValidModel_ReturnsTrue()
        {
            // Arrange
            var employee = new Employee
            {
                Name = "Juan",
                Position = "Developer",
                Office = "Medellin",
                Salary = 5000000
            };

            // Act
            var context = new ValidationContext(employee, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(employee, context, results, true);

            // Assert
            Assert.IsTrue(isValid);
        }
    }
}
