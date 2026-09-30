using System;

int num = int.Parse(Console.ReadLine());

string[] name = new string[num];
int[] first = new int[num];
int[] second = new int[num];

int max = 0;

for(int i = 0; i < num; i++)
{
    name[i] = Console.ReadLine();
    first[i] = int.Parse(Console.ReadLine());
    second[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < num; i++)
{
    int up = second[i] - first[i];

    if (up > 0)
    {
        Console.WriteLine($"{name[i]}: +{up}");

        if (up > max)
        {
            max = up;
        }
    }
}

if (max == 0)
{
    Console.WriteLine("최고 향상: 없음");
}
else
{
    Console.Write("최고 향상:");

    for (int i = 0; i < num; i++)
    {
        int up = second[i] - first[i];

        if (up == max)
        {
            Console.Write($" {name[i]}");
        }
    }

    Console.WriteLine();
}
