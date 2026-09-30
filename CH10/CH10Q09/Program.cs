using System;

int limit = int.Parse(Console.ReadLine());
int count = int.Parse(Console.ReadLine());

int num = 0;
int sum = 0;
int error = 0;
int total = 0;


for(int i = 1; i <= count; i++)
{
    int a = int.Parse(Console.ReadLine());
    total++;
    if(a <= limit)
    {
        if ((sum + a) <= limit)
        {
            sum += a;
            num++;
            if (sum == limit)
            {
                break;
            }
        }
        else
        {
            error++;
            continue;
        }
    }
    else
    {
        error++;
    }
}

Console.WriteLine($"적재 개수: {num}");
Console.WriteLine($"총무게: {sum}");
Console.WriteLine($"제외 개수: {error}");
Console.WriteLine($"검사 수: {total}");
