using System;

int n = int.Parse(Console.ReadLine());
int[] origin = new int[n];
int[] swap = new int[n];
int discount = 0;
int num = 0;
int change = 0;

for(int i = 0; i < n; i++)
{
    origin[i] = int.Parse(Console.ReadLine());
}

discount = int.Parse(Console.ReadLine());
num = int.Parse(Console.ReadLine());
change = int.Parse(Console.ReadLine());

for(int i =0; i < n; i++)
{
    swap[i] = origin[i];
}

origin[num - 1] = change;

for(int i = 0; i< n; i++)
{
    swap[i] -= discount;
    if(swap[i] < 0) swap[i] = 0;
}

Console.WriteLine("원본: " + string.Join(" ",origin));
Console.WriteLine("미리보기: " + string.Join(" ", swap));

