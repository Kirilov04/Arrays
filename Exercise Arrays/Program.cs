int[] numbers = Console.ReadLine()
    .Split(' ')
    .Select(int.Parse)
    .ToArray();

//int[] arr = Console.ReadLine().Split( ' '). Select(int.Parse).ToArray();

for (int i = 0; i < numbers.Length; i++)
{
    string name = Console.ReadLine();

    numbers[i] = int.Parse(name);
}

Console.WriteLine(numbers);