//•	Reads sequence of integer numbers from the first line of the console
//•	Find all the top integers in a sequence
//•	Top integer is an integer that is bigger than all the elements to its right
//
//     Input                   Output
//    1 4 3 2	                4 3 2
//    14 24 3 19 15 17          24 19 17
//    27 9 42 2 13 45 48        48 
//
//



using System.Collections.Generic;
using System.Runtime.ExceptionServices;

List<int> input = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
List<int> output = new List<int> ();

for (int i = 0; i < input.Count-1; i++)
{   
        int first = input[i];    
        int second = input[i + 1];
        if (first > second)
        {
            output.Add(first);
        }
 }
int lastElement = input[input.Count - 1];
if(output.Count>0 && lastElement > output[output.Count - 1])
{
    output.Clear();
    output.Add(lastElement);
}
else
{
    output.Add(lastElement);
}

Console.WriteLine(string.Join(" ", output));