using System;

int num = int.Parse(Console.ReadLine());

string[] name = new string[num];
string[] changed = new string[num];

for (int i = 0; i < num; i++)
{
    name[i] = Console.ReadLine();
}

int a = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    changed[i] = name[i];
}

if (num > 0)
{
    for (int move = 0; move < a; move++)
    {
        string last = changed[num - 1];

        for (int i = num - 1; i > 0; i--)
        {
            changed[i] = changed[i - 1];
        }

        changed[0] = last;
    }
}

Console.Write("원본:");

for (int i = 0; i < num; i++)
{
    Console.Write($" {name[i]}");
}

Console.WriteLine();

Console.Write("변경:");
for (int i = 0; i < num; i++)
{
    Console.Write($" {changed[i]}");
}
Console.WriteLine();
