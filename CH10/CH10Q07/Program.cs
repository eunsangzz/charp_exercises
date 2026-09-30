using System;

int a = int.Parse(Console.ReadLine());
int group = 1;
int total = 0;

for(int i = 0; i < a; i++)
{
    while (true)
    {
        int b = int.Parse(Console.ReadLine());
        int sum = 0;

        if (b >= 0)
        {
            if (b > 0)
            {
                total++;
                sum += b;
                if (sum == 0)
                {
                    break;
                }
            }
            else
            {
                total++;
                continue;
            }
        }

        Console.WriteLine($"")
    }
}
