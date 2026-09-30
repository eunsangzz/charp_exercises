using System;

string memo = "";
int a = int.Parse(Console.ReadLine());
int count = 0;
int num = 0;

while(count < a)
{
    string str = Console.ReadLine();

    if(str == "")
    {
        count++;
        continue;
    }
    else
    {
        count++;
        num++;
        memo += str;
        if(count < a)
        {
            memo += ", ";
        }
    }
}

Console.WriteLine($"메모: [{memo}]");
Console.WriteLine($"남긴 메모: {num}");
