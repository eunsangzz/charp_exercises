using System;


int count = int.Parse(Console.ReadLine());

int[] n = new int[count];

int maxNum = 0;

for(int i = 0; i < count; i++)
{
    int num = int.Parse(Console.ReadLine());
    n[i] = num;
}

for(int i = 0; i < n.Length - 1; i++)
{
        if (n[i] > n[i + 1])
        {
            Console.WriteLine($"{i}번: {n[i]}");
            maxNum++;
        }
    
}
Console.WriteLine($"개수: {maxNum}");  
