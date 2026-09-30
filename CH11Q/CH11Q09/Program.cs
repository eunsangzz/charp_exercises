using System;

int num = int.Parse(Console.ReadLine());
int[] stock = new int[num];

for(int i = 0; i < num; i++)
{
    stock[i] = int.Parse(Console.ReadLine());
}

int count = int.Parse(Console.ReadLine());

for(int i = 0; i < count; i++)
{
    int from = int.Parse(Console.ReadLine());
    int to = int.Parse(Console.ReadLine());
    int amount = int.Parse(Console.ReadLine());

    if(from < 1 || from >num || to < 1 || to > num || from == to || amount <1)
    {
        Console.WriteLine("요청 오류");
    }
    else if (stock[from - 1] < amount)
    {
        Console.WriteLine("재고 부족");
    }
    else
    {
        stock[from - 1] -= amount;
        stock[to - 1] += amount;

        Console.WriteLine("이동 완료");
    }
}

int total = 0;

for(int i = 0;i < num; i++)
{
    Console.WriteLine($"{i + 1}번: {stock[i]}");
    total += stock[i];
}

Console.WriteLine($"전체: {total}");
