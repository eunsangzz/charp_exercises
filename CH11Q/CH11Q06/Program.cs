using System;

int num = int.Parse(Console.ReadLine());
string[] name = new string[num];
int[] first = new int[num];
int[] second = new int[num];
int[] vs = new int[num];

for(int i = 0; i < num; i++)
{
    name[i] = Console.ReadLine();
    first[i] = int.Parse(Console.ReadLine());
    second[i] = int.Parse(Console.ReadLine());
}

for(int i = 0;i < num; i++)
{
    vs[i] = second[i] - first[i];
    if (vs[i] >= 0)
    {
        Console.WriteLine(name[i] + $": +{vs[i]}");
    }
    else
    {
        Console.WriteLine(name[i] + $": -{vs[i]}");
    }
}

if()