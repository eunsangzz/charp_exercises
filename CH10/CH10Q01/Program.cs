using System;

int a = int.Parse((Console.ReadLine())); //상품 수
int goal = int.Parse((Console.ReadLine())); //상품 번호
int count = 0;
bool found = false;


for (int i = 1; i <= a; i++)
{
    count++;

    int c = int.Parse((Console.ReadLine()));
    if (c == goal)
    {
        found = true;
        break;
    }
}

if(found)
{
    Console.WriteLine($"첫 위치: {count}");
    Console.WriteLine($"검사 수: {count}");
}
else
{
    Console.WriteLine("상품 없음");
}



