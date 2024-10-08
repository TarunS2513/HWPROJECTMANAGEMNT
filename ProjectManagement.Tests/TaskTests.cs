using NUnit.Framework;
using projectmanagement.entity;
using projectmanagement.main;
using projectmanagement.dao;

namespace ProjectManagement.Tests
{
    [TestFixture]
    public class TaskTests
    {
        [Test]
        public void Test_TaskCreatedSuccessfully()
        {
            // Arrange
            var repository = new ProjectRepositoryImpl(); 
            var task = new projectmanagement.entity.Task 
            {
                TaskId = 1,
                TaskName = "Implement Feature",
                ProjectId = 1,
                EmployeeId = 1,
                Status = "Assigned"
            };

            // Act
            var result = repository.CreateTask(task); 

            // Assert
            Assert.IsTrue(result, "Task should be created successfully.");
        }
    }
}
