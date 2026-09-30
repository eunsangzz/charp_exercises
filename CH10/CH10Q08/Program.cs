using System;

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int total = 0;
int row = 0;
int col = 0;

for(int i = 1; i <= a; i++)
{
    row++;

    for(int j = 1; j <= b; j++)
    {
        total++;
        col++;
        int seat = int.Parse(Console.ReadLine());
        if(seat == 0)
        {
            row = i;
            col = j;
            break;
        }    
    }
}

Console.WriteLine($"빈 좌석: {row}행 {col}열");
Console.WriteLine($"검사 칸: {total}");

