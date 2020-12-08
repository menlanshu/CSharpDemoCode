using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnitTestDemoLibrary;
using Xunit;

namespace UnitTestDemo
{
    public class TestExample
    {
        [Fact]
        public void ExampleLoadTextFile_NormalTest()
        {
            // Arrange
            string expected = "The file was correctly loaded.";
            Examples testObject = new Examples();

            // Act
            string actual = testObject.ExampleLoadTextFile("This is a normal test");

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ExampleLoadTextFile_ExceptionTest()
        {
            // Arrange
            Examples testObject = new Examples();

            // Act

            // Assert
            // Assert.Throws<FileNotFoundException>(() => testObject.ExampleLoadTextFile(""));
            Assert.Throws<ArgumentException>("file", () => testObject.ExampleLoadTextFile(""));
        }
    }
}
