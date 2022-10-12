using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMissingNumber.core;
using FindMissingNumber.core.Exceptions;

namespace FindMissingNumber
{
    public class MissingNumberAnalyzer : IMissingNumberAnalyzer
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

