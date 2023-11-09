//int[] inputNum = int.Parse(Console.ReadLine()   
    //.Split
    //.Select(int.Parse)
    //.ToArray());}



int[] inputNum = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToArray();

int evenNumbersSum = 0;

for (int i = 0; i < inputNum.Length; i++)
{
    if (inputNum[i] % 2 == 0)
    {
        evenNumbersSum += inputNum[i];
    }
}
Console.WriteLine(evenNumbersSum);

