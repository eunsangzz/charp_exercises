using System;

int a;
int answer = 0;
int count = 0;

for (int i = 0; i < 3; i++)
{
    string str = Console.ReadLine();
    bool success = int.TryParse(str, out int result);

    if (success)
    {
        a = int.Parse(str);
        if (a > 0 && a < 11)
        {
            answer = a;
            count++;
            break;
        }
        else
        {
            count++;
            Console.WriteLine("범위 오류");
            continue;
        }
    }
    else
    {
        count++;
        Console.WriteLine("정수 필요");
    }
}

Console.WriteLine($"확정 번호: {answer}");
Console.WriteLine($"시도 수: {count}");

