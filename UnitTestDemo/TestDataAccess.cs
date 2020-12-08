using System;
using System.Collections.Generic;
using System.Text;
using UnitTestDemoLibrary;
using UnitTestDemoLibrary.Models;
using Xunit;

namespace UnitTestDemo
{
    public class TestDataAccess
    {

        [Fact]
        public void ConvertModelsToCSV_SimpleNormalCase()
        {
            // Arrange
            List<IPersonModel> people = new List<IPersonModel>()
            {
            new PersonModel { FirstName = "fu", LastName = "long" },
            };

            List<string> expected = new List<string>() { "fu,long", };
            DataAccess testObject = new DataAccess();

            // Act
            var actual = testObject.ConvertModelsToCSV(people);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
