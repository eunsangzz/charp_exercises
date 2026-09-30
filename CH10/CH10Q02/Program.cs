using System;

int a = int.Parse(Console.ReadLine()); //기록 수
int sum = 0;
int error = 0;
int count = 0;

for(int i = 1; i <= a; i++)
{
    int b = int.Parse(Console.ReadLine()); // 생산량

    if(b >= 0)
    {
        sum += b;
        count++;
    }
    else
    {
        error++;
    }
}

Console.WriteLine($"정상 기록: {count}");
Console.WriteLine($"제외 기록: {error}");
Console.WriteLine($"생산량: {sum}");