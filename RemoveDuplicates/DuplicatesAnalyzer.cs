using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RemoveDuplicates.core;
using RemoveDuplicates.core.Exceptions;


namespace RemoveDuplicates
{
    public class DuplicatesAnalyzer : IDuplicatesAnalyzer
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
