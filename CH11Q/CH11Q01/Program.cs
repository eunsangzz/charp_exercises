using System;


int a = int.Parse(Console.ReadLine());//박수 수
int m = int.Parse(Console.ReadLine()); //입고 횟수
int total = 0;

int[] box= new int[a];


for(int i = 0; i < m; i++)
{
    int num = int.Parse(Console.ReadLine());
    int value = int.Parse(Console.ReadLine());

    box[num-1] += value;
}

for(int i = 0; i < a; i++)
{
    Console.WriteLine($"{i}번: {box[i]}");
}

foreach (int j in box)
{
    total += j;
}

Console.WriteLine($"전체: {total}");

