using Employee_Management.Controllers;
using Employee_Management.IRepository;
using Employee_Management.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Employee_Management.Tests.Controller_Test
{
    [TestClass]
    public class EmployeeControllerTests
    {
        private Mock<IEmployeeRepository> _mockRepo;
        private EmployeeController _controller;

        [TestInitialize]
        public void Setup()
        {
            _mockRepo = new Mock<IEmployeeRepository>();
            _controller = new EmployeeController(_mockRepo.Object);
        }

        [TestMethod]
        public async Task GetEmployees_ReturnsJsonResult()
        {
            // Arrange
            _mockRepo.Setup(repo => repo.GetEmployees())
                     .ReturnsAsync(new JsonResult());

            // Act
            var result = await _controller.GetEmployees();

            // Assert
            Assert.IsInstanceOfType(result, typeof(JsonResult));
            _mockRepo.Verify(repo => repo.GetEmployees(), Times.Once);
        }

        [TestMethod]
        public async Task GetEmployeeById_ValidId_ReturnsJsonResult()
        {
            // Arrange
            int employeeId = 1;
            _mockRepo.Setup(repo => repo.GetEmployeeById(employeeId))
                     .ReturnsAsync(new JsonResult());

            // Act
            var result = await _controller.GetEmployeeById(employeeId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(JsonResult));
            _mockRepo.Verify(repo => repo.GetEmployeeById(employeeId), Times.Once);
        }

        [TestMethod]
        public async Task AddEmployee_ValidEmployee_ReturnsJsonResult()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "Juan Jose", Position = "Backend Developer", Office = "Medellin", Salary = 3000000 };
            _mockRepo.Setup(repo => repo.AddEmployee(employee))
                     .ReturnsAsync(new JsonResult());

            // Act
            var result = await _controller.AddEmployee(employee);

            // Assert
            Assert.IsInstanceOfType(result, typeof(JsonResult));
            _mockRepo.Verify(repo => repo.AddEmployee(employee), Times.Once);
        }

        [TestMethod]
        public async Task UpdateEmployee_ValidEmployee_ReturnsJsonResult()
        {
            // Arrange
            var employee = new Employee { Id = 1, Name = "Juan", Position = "Full-Stack Developer", Office = "Bogota", Salary = 5000000 };
            _mockRepo.Setup(repo => repo.UpdateEmployee(employee))
                     .ReturnsAsync(new JsonResult());

            // Act
            var result = await _controller.UpdateEmployee(employee);

            // Assert
            Assert.IsInstanceOfType(result, typeof(JsonResult));
            _mockRepo.Verify(repo => repo.UpdateEmployee(employee), Times.Once);
        }

        [TestMethod]
        public async Task DeleteEmployee_ValidId_ReturnsJsonResult()
        {
            // Arrange
            int employeeId = 1;
            _mockRepo.Setup(repo => repo.DeleteEmployee(employeeId))
                     .ReturnsAsync(new JsonResult());

            // Act
            var result = await _controller.DeleteEmployee(employeeId);

            // Assert
            Assert.IsInstanceOfType(result, typeof(JsonResult));
            _mockRepo.Verify(repo => repo.DeleteEmployee(employeeId), Times.Once);
        }

    }
}
