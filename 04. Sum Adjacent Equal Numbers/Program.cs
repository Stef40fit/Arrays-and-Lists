//•	Reads a sequence of integer numbers from the console
//•	Sum all adjacent equal numbers in a list of decimal numbers, starting from left to right
//o	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well
//o	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available)

List<int> input = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();

for(int i = 0; i < input.Count-1; i++)
{
int num1 = input[i];
int num2 = input[i + 1];

    if(num1 == num2)
    {
     
        input[i] = num1 + num2;    
        input.RemoveAt(i + 1);
        i = -1;
    }
}






Console.WriteLine(string.Join(" ", input));