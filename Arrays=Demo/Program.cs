int n = int.Parse(Console.ReadLine());

string[] numbers = new String[n];

for (int i = 0; i < numbers.Length; i++)
{
    string input = (Console.ReadLine());

    numbers[i] = input;
}

for (int i = 0; i < numbers.Length; i++)
{
    Console.Write($"{numbers[i]} ");
}


