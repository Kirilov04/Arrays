// int numbers = int.Parse(Console.ReadLine());
//
// int[] arr = new int[numbers];
//
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = numbers;
//     Console.Write(string.Join(" ", arr[i]));
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = numbers;
//     Console.Write(arr[i] + " ");
// }

int numbers = int.Parse(Console.ReadLine());
int[] arr = new int[numbers];


for (int i = 0; i < arr.Length; i++)
{
    arr[i] = numbers;
    
    for (int j = 0; j < arr.Length - 1; j++)
    {
        arr[j] = numbers;
        Console.Write(arr[j] + " ");
    }
    Console.WriteLine(arr[i]);
}