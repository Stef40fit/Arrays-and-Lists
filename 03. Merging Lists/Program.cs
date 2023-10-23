//•	Reads two sequences with integer numbers from the console
//•	Create a result list that contains the numbers from both of the sequences
//•	The first element should be from the first sequence, the second from the second sequence, and so on
//•	If the length of the two sequences is not equal, just add the remaining elements at the end of the sequence

List<int> input1 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
List<int> input2 = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
List<int> result = new List<int> ();

int longerCoun = Math.Max(input1.Count, input2.Count);
for  (int i = 0; i < longerCoun; i++)
{
    
    if (i < input1.Count)
    {
        result.Add(input1[i]);
    }
    if (i < input2.Count)
    {
        result.Add(input2[i]);
    }
   
}
Console.WriteLine(string.Join(" ",result));