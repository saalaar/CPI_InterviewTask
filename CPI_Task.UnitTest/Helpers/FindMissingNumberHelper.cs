using System.Linq;
using FindMissingNumber.core;
using FindMissingNumber.core.Exceptions;

namespace CPI_Task.UnitTest.Helpers
{
    internal class FindMissingNumberHelper : IMissingNumberAnalyzer
    {
        public int[] Analyze(string inputStatement)
        {
            if (string.IsNullOrEmpty(inputStatement))
                throw new GivenStringIsEmpty();

            int[] numbers = inputStatement.Split(',').Select(int.Parse).ToArray();

            return numbers;
        }

        public int MissingFinder(int[] arr)
        {
            int TempArr = arr[0];
            int DestArr = 1;

            for (int i = 1; i < arr.Length; i++)
                TempArr = TempArr ^ arr[i];

            for (int i = 2; i <= arr.Length + 1; i++)
                DestArr = DestArr ^ i;

            return (TempArr ^ DestArr);
        }
    }
}
