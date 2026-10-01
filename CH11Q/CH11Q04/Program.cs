using System;

int row = int.Parse(Console.ReadLine()); 
int col = int.Parse(Console.ReadLine()); 

int[,] arr = new int[col, row];
int[] num = new int[(row * col)];

for (int i = 0; i < row * col; i++)
{
    num[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < col; i++)
{
    for (int j = 0; j < row; j++)
    {
        arr[i, j] = num[i + (j * col)];
    }
}

for (int i = 0; i < col; i++) 
{
    for(int  k = 0; k < row; k++) 
    {
        Console.Write(arr[i, k]);
    }
    Console.WriteLine("");
}
