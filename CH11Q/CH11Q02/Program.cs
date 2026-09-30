using System;

int n = int.Parse(Console.ReadLine());

int[] arr = new int[n];

for(int i = 0; i < n; i++)
{
    int value = int.Parse(Console.ReadLine());
    arr[i] = value;
}

for (int i = 0; i < n / 2; i++)
{
    int temp = arr[i];
    arr[i] = arr[n - 1 - i];
    arr[n - 1 - i] = temp;
}

Console.Write("목록:");

foreach(int value in arr)
{
    Console.Write($" {value}");
}

Console.WriteLine();