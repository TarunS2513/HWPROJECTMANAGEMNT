using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using projectmanagement.entity;
using projectmanagement.main;
using projectmanagement.dao;
using projectmanagement.exception;
namespace ProjectManagement.Tests
{
    public class ExceptionHandlingTests
    {
        [Test]
        public void Test_EmployeeNotFoundExceptionThrown()
        {
            // Arrange
            var repository = new ProjectRepositoryImpl();
            var nonExistentEmployeeId = -1;

            // Act & Assert
            Assert.Throws<EmployeeNotFoundException>(() => repository.AssignProjectToEmployee(nonExistentEmployeeId, 1));
        }

        [Test]
        public void Test_ProjectNotFoundExceptionThrown()
        {
            // Arrange
            var repository = new ProjectRepositoryImpl();
            var nonExistentProjectId = -1;

            // Act & Assert
            Assert.Throws<ProjectNotFoundException>(() => repository.AssignProjectToEmployee(1, nonExistentProjectId));
        }

    }
}
