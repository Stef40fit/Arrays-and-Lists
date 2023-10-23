using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {

        string input = Console.ReadLine();
        List<int> numbers = input.Split().Select(int.Parse).ToList();

        List<int> topIntegers = FindTopIntegers(numbers);


        foreach (int topInt in topIntegers)
        {
            Console.Write(topInt + " ");
        }
    }

    static List<int> FindTopIntegers(List<int> numbers)
    {
        List<int> topIntegers = new List<int>();

        for (int i = 0; i < numbers.Count; i++)
        {
            bool isTopInteger = true;

            for (int j = i + 1; j < numbers.Count; j++)
            {
                if (numbers[i] <= numbers[j])
                {
                    isTopInteger = false;
                    break;
                }
            }

            if (isTopInteger)
            {
                topIntegers.Add(numbers[i]);
            }
        }

        return topIntegers;
    }
}

///////////////////////////////////////////////

//////•	Reads sequence of integer numbers from the first line of the console
//////•	Find all the top integers in a sequence
//////•	Top integer is an integer that is bigger than all the elements to its right

////using System.Collections.Generic;
////using System.Runtime.ExceptionServices;

////List<int> input = Console.ReadLine()
////                        .Split()
////                        .Select(int.Parse)
////                        .ToList();
////List<int> output = new List<int>();


////for (int i = 0; i < input.Count - 1; i++)
////{
////    for (int j = i + 1; j <= input.Count-1; j++)
////    { 
////     int first = input[i];
////     int second = input[j]; 

////        if (first > second)
////        {
////            output.Add(first);
////        }

////    }
////}
//////output.Add(input[input.Count - 1]);
////Console.WriteLine(string.Join(" ", output));



//// Read a sequence of ints from the console
//List<int> inputNumbers = Console.ReadLine()
//                        .Split()
//                        .Select(int.Parse)
//                        .ToList();
//List<int> outputNumbers = new List<int>();

//// Go through each number in the sequence
//for (int i = 0; i < inputNumbers.Count - 1; i++)
//{
//    // Compare current number with each of its successors
//    for (int j = i + 1; j <= inputNumbers.Count - 1; j++)
//    {
//        int current = inputNumbers[i];
//        int next = inputNumbers[j];

//        // If current number is larger than successor, add it to output list
//        if (current > next)
//        {
//            outputNumbers.Add(current);
//        }
//    }
//}
//// Write the output sequence to console
//Console.WriteLine(string.Join(" ", outputNumbers));
