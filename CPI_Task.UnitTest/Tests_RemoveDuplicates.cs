using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using RemoveDuplicates;
using RemoveDuplicates.core.Exceptions;
using RemoveDuplicates.core;


namespace CPI_Task.UnitTest
{
    [TestClass]
    public class Tests_RemoveDuplicates
    {


        readonly string resourcesPath;
        public Tests_RemoveDuplicates()
        {
            resourcesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");
        }

        [TestMethod]
        [Description("Analyze input with Large Array ")]
        public void ArrayAnalyzeWithLongLenInput()
        {
            // arrange
            var output= new string[] { };
            var res = new string[] {};
            var expected = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            string input = File.ReadAllText(Path.Combine(resourcesPath, "LongDuplicatedArray_one to Nine.txt"));
           
            DuplicatesAnalyzer analyzer = new DuplicatesAnalyzer();

            // act && assert
            try
            {
                 res= analyzer.Analyze(input);
                 output= analyzer.RemoveDuplicates(res);
            }
            catch (Exception ex)
            {
                return;
            }
            catch
            {
                Assert.Fail("can not be analyzed .");
            }
            Assert.Equals(output , expected);
        }
    }

}
