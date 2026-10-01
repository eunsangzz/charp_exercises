using System;

//참여자수
int member = int.Parse(Console.ReadLine());

//점수기록
int[][] score = new int[member][];

//참여자 수만큼 반복
for(int i = 0; i < member; i++)
{

    int num = int.Parse(Console.ReadLine());
    if (num == 0)
    {
        score[i] = new int[0];
        continue;
    }

    score[i] = new int[num];

    //참여자의 기록개수만큼 반복해서 점수 받기
    for (int j = 0; j < num; j++)
    {
        score[i][j] = int.Parse(Console.ReadLine()); 
            
    }
}
int totalCount = 0;

// 최대 기록 개수는 5개
for (int round = 0; round < 5; round++)
{
    int count = 0;
    int sum = 0;

    // 모든 참여자 확인
    for (int i = 0; i < member; i++)
    {
        // 참여자가 이 회차 기록을 가지고 있는지 확인
        if (round < score[i].Length)
        {
            sum += score[i][round];
            count++;
        }
    }

    if (count > 0)
    {
        Console.WriteLine($"{round + 1}회차: {count}명, 합계 {sum}");
        totalCount += count;
    }
}

Console.WriteLine($"전체 기록: {totalCount}");