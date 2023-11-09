using System;

double[] inputNum = Console.ReadLine()      
    .Split()
    .Select(double.Parse)
    .ToArray();

for (int i = 0; i < inputNum.Length; i++)
{
   
    //Console.Write(string.Join(", ", inputNum[i]));
}
Console.Write(string.Join(", ", inputNum[i]));
