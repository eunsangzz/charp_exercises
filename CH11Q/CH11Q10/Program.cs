using System;

//행
Console.Write("행 수: ");
int r = int.Parse(Console.ReadLine());
//열
Console.Write("열 수: ");
int c = int.Parse(Console.ReadLine());
//예약요청수
Console.Write("예약 요청 수: ");
int m = int.Parse(Console.ReadLine());

//좌석 2차원 배열
bool[,] seat = new bool[r, c];


for(int i = 0; i < m; i++)
{
    Console.WriteLine();
    Console.WriteLine($"[예약 요청 {i + 1}]");

    Console.Write("행 번호: ");
    int rowNumber = int.Parse(Console.ReadLine());
    Console.Write("시작 열 번호: ");
    int col = int.Parse(Console.ReadLine());
    Console.Write("인원: ");
    int member = int.Parse(Console.ReadLine());

    if (rowNumber < 1 || rowNumber > seat.GetLength(0) || col < 1 || col > seat.GetLength(1) || member < 1 ||
        (col + member - 1) > seat.GetLength(1))
    {
        Console.WriteLine("범위 오류");
        continue;
    }

    int row = rowNumber - 1;
    int start = col - 1;
    bool availble = true;

    for(int column = start; column < start + member; column++)
    {
        if (seat[row,column])
        {
            availble = false;
            break;
        }
    }

    if(!availble)
    {
        Console.WriteLine("예약 불가");
        continue;
    }

    for (int column = start; column < start + member; column++)
    {
        seat[row,column] = true;
    }
    Console.WriteLine("예약 완료");
}

int reserved = 0;
for(int row = 0; row < seat.GetLength(0); row++)
{
    for(int column = 0; column < seat.GetLength(1); column++)
    {
        Console.Write(seat[row, column] ? "X" : "0");
        if (seat[row, column])
        {
            reserved++;
        }
    }
    Console.WriteLine();
}

Console.WriteLine($"예약 좌석: {reserved}");
