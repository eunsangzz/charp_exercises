using System;


int num = int.Parse(Console.ReadLine());
bool quit = false;
string undocomand = "";



while(!quit)
{
    string command = Console.ReadLine();

    switch(command)
    {
        case ("add"):
            num++;
            undocomand = "add";
            Console.WriteLine("추가 완료" + Environment.NewLine + $"수량: {num}");
            break;
        case ("remove"):
            undocomand = "remove";
            num--;
            Console.WriteLine("감소 완료" + Environment.NewLine + $"수량: {num}");
            break;
        case ("undo"):
            if(undocomand == "add")
            {
                num--;
            }
            else if(undocomand =="remove")
            {
                num++;
            }
            else
            {
                Console.WriteLine("변경 없음");
            }

            Console.WriteLine("되돌림 완료" + Environment.NewLine + $"수량: {num}");
            break;
        case ("quit"):
            Console.WriteLine($"최종 수량: {num}");
            quit = true;
            break;
    }   
}
