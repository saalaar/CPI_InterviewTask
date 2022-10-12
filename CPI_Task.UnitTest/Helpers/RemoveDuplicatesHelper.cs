using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMissingNumber.core.Exceptions;
using RemoveDuplicates;

using RemoveDuplicates.core;



namespace CPI_Task.UnitTest.Helpers
{
    internal class RemoveDuplicatesHelper :  IDuplicatesAnalyzer
    {
        public string[] Analyze(string inputStatement)
        {
            if (string.IsNullOrEmpty(inputStatement))
                throw new GivenStringIsEmpty();

            string[] pieces = inputStatement.Split(new string[] { "," },
                StringSplitOptions.None);

            return pieces;
        }

        public string[] RemoveDuplicates(string[] arr)
        {
            //string output;
            string[] unique = arr.Distinct().ToArray();
            // output = arr.ForEach(unique, j => Console.WriteLine(j));
            return unique;

        }
    }
}
