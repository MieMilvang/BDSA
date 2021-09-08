using System;
using Xunit;
using System.IO;

namespace MyApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }
        [Fact]
        public void IsLeapYear_For_Year2020_ReturnTrue()
        {
            bool result = Program.isLeapYear(2000);
            Assert.True(result);
        }
        [Fact]
        public void IsLeapYear_For_Year2000_ReturnTrue()
        {
            bool result = Program.isLeapYear(2000);
            Assert.True(result);
        }
        [Fact]
        public void IsLeapYear_For_Year1700_ReturnFalse()
        {
            bool result = Program.isLeapYear(1700);
            Assert.False(result);
        }
        [Fact]
        public void IsLeapYear_For_Year2001_ReturnFalse()
        {
            bool result = Program.isLeapYear(2001);
            Assert.False(result);
        }
        
        [Fact]
        public void IsLeapYear_For_1500_ThrowsFormatExeption()
        {
            Assert.Throws<ArgumentException>(() => Program.isLeapYear(1500));
        }

        [Fact] //press enter for the program to run the tests
        public void IsLeapYear_For_String_ThrowsFormatExeption()
        {
            var writer = new StringWriter();
            Console.SetOut(writer);

            Program.Main(new string[0]);
            string[] outputArray = writer.ToString().Split("\n");
            
            Assert.Equal("Input string was not in a correct format.", outputArray[2]);

        }
    }
}
