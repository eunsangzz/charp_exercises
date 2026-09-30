using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

int limit = int.Parse(Console.ReadLine());
int sum = 0;
int count = 0;
int stop = 0;

while(sum <= limit)
{
    int a = int.Parse(Console.ReadLine());
    if (limit >= (sum + a))
    {
        sum += a;
        count++;
    }
    else
    {
        stop++;
        break;
    }
}

Console.WriteLine($"적재 개수: {count}");
Console.WriteLine($"총무게: {sum}");
Console.WriteLine($"중단 물품: {stop}");

