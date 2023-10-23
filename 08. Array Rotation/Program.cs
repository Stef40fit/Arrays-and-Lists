//•	Reads sequence of integer numbers from the first line of the console
//•	Reads an integer number (rotations you have to perform) from the second line of the console
//•	Each rotation is when the first element goes at the end
//•	Print the resulting sequence

List<int> input = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    int num = input[0];
    input.Add(num);
    input.RemoveAt(0);

}

Console.WriteLine(string.Join(" ", input));