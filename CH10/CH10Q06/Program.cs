using System;

string option = Console.ReadLine();
int price = 0;

switch(option)
{
    case "box":
        price += 300;
        break;
    case "gift":
        price += 500;
        goto case "box";
}


Console.WriteLine($"포장비: {price}");