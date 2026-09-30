using System;

int n = int.Parse(Console.ReadLine());

float[] arr = new float[n];

for(int i = 0; i < n; i++)
{
    float value = float.Parse(Console.ReadLine());
    arr[i] = value;
}

foreach(float i in arr)
{
    
}

Console.WriteLine($"목록: {arr}");