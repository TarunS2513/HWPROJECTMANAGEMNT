using NUnit.Framework;
using projectmanagement.entity;
using projectmanagement.main;
using projectmanagement.dao;

namespace ProjectManagement.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void Test_EmployeeCreatedSuccessfully()
        {
            // Arrange
            var repository = new ProjectRepositoryImpl();
            var employee = new Employee
            {
                Id = 1,
                Name = "John Doe",
                Designation = "Developer",
                Gender = "M",
                Salary = 50000,
                ProjectId = 3
            };

            // Act
            var result = repository.CreateEmployee(employee);

            // Assert
            Assert.IsTrue(result, "Employee should be created successfully.");
        }

    }
}