using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var listOfIntegers = new List<int> { 1, 2, 3, 4, 10, 20 };

            //Standard without using Linq
            var newList = new List<int>();
            foreach (var i in listOfIntegers)
            {
                var n = i * 2;
                newList.Add(n);
            }

            // Using Linq to map/select over items in a collection 
            var newList2 =
                listOfIntegers.Select(number => number * 2);

            var newList3 =
                listOfIntegers.Select(TimesTwo);

            var newList4 =
                listOfIntegers.Select(x => MultiArgumentFunction(10, 20, x));

            var newListAsStrings =
                listOfIntegers.Select(tall => "Result is " + (tall * 2).ToString());

            // Using Aggregate
            var newListOfOddsSummarized =
                listOfIntegers
                    .Where(x => x % 2 != 0)
                    .Sum();

            var newListOfOddsSummarizedWithAccumulateFunction =
                listOfIntegers
                    .Where(x => x % 2 != 0)
                    .Aggregate(0, AccumulateNumbers);

            var newListOfOddsSummarizedWithAccumulateLambda =
                listOfIntegers
                    .Where(x => x % 2 != 0)
                    .Aggregate(0, (accumulated, current) => accumulated + current);


            // Writing collection to console
            foreach (var i in newList3)
            {
                Console.WriteLine($"The values are {i}");
            }
        }

        private static int TimesTwo(int aNumber)
        {
            return aNumber * 2;
        }

        private static int AccumulateNumbers(int accumulated, int current)
        {
            return accumulated + current;
        }
        private static int MultiArgumentFunction(int existingNumber1, int existingNumber2, int aNumber)
        {
            return existingNumber1 + existingNumber2 + aNumber * 2;
        }
    }
}
