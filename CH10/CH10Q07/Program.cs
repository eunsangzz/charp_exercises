using System;

int a = int.Parse(Console.ReadLine());
int total = 0; //전체수량

for (int i = 1; i <= a; i++)
{
    int num1 = 0; //묶음별 유효묶음
    int num2 = 0; //묶음별 전체묶음

    while (true)
    {
        int b = int.Parse(Console.ReadLine());
        int sum = 0; //수량합

        if (b >= 0)
        {
            num1++;
            if (b > 0)
            {
                sum += b;
                total += sum;
                num2++;
            }
            if (sum == 0)
            {
                break;
            }
        }
    }

    Console.WriteLine($"묶음 {i}: {num2}건 / {num1}개");
}

Console.WriteLine($"전체 수량: {total}");
