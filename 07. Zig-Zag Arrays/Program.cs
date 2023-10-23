//•	Creates two empty integer arrays
//•	Reads an integer number N from the console
//•	Reads two integer numbers on the next N lines 
//•	Form two integer arrays as shown below


int n = int.Parse(Console.ReadLine());
List<int> list1 = new List<int>(); 
List<int> list2 = new List<int>(); 


for(int i =0; i < n; i++)
{
    List<int> input = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToList();
    int num1 = input[0];
    int num2 = input[1];
    if(i %2 == 0)
    {
        list1.Add(num1);
        list2.Add(num2);
    }
    else 
    {
        list1.Add(num2);
        list2.Add(num1);
    }
    
}
Console.WriteLine(string.Join(" ", list1));
Console.WriteLine(string.Join(" ", list2));
