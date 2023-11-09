int n = int.Parse(Console.ReadLine());

int[] input = new int[n];

int peopleCount = 0;

for (int i = 0; i < input.Length; i++)
{
    int people = int.Parse(Console.ReadLine());
    input[i] = people;
    
    peopleCount += people;
}

System.Console.WriteLine(string.Join(" ", input));
System.Console.WriteLine(peopleCount);