using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using FindMissingNumber;
using FindMissingNumber.core.Exceptions;

namespace CPI_Task.UnitTest
{
   

    [TestClass]
    public class Tests_FindMissingNumber
    {



        [TestMethod]
        [Description("Analyze null input ")]
        public void ArrayAnalyzeWithNullInput()
        {
            // arrange
            int[] input = new int[] { };
            MissingNumberAnalyzer analyzer = new MissingNumberAnalyzer();

            // act && assert
            try
            {
                analyzer.MissingFinder(input);
            }
            catch (GivenStringIsEmpty)
            {
                return;
            }
            catch
            {
                Assert.Fail("GivenInputIsEmpty was not thrown.");
            }
            Assert.Fail("No exception was thrown.");
        }

        [TestMethod]
        [Description("Analyze input with negative numbers ")]
        public void ArrayAnalyzeWithNegativeInput()
        {
            // arrange
            int[] input = new int[] {-1,0,1,2,4 };
            int output = 3;
            MissingNumberAnalyzer analyzer = new MissingNumberAnalyzer();

            // act && assert
            try
            {
                analyzer.MissingFinder(input);
            }
            catch (GivenNumberIsZeroOrNegativeException)
            {
                return;
            }
            catch
            {
                Assert.Fail("GivenInputIsInclude negative .");
            }
            Assert.Equals(output,3);
        }

       

    }
}
