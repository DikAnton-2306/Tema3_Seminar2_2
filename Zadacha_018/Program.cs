// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

int DataQvadrant(string str)
{
    Console.Write(str);
    //int number = Convert.ToInt32(Console.ReadLine());
    int number = int.Parse(Console.ReadLine());
    return number;
}

void PrintXY (int count)
{
    if(count < 1 || count > 4) Console.WriteLine("Не подходящее число");
    else
    {        
        if(count == 1) Console.WriteLine("x > 0 и y > 0");
        if(count == 2) Console.WriteLine("x < 0 и y > 0");
        if(count == 3) Console.WriteLine("x < 0 и y < 0");
        if(count == 4) Console.WriteLine("x > 0 и y < 0");
    }
}

int quarter = DataQvadrant("Напишите номер четверти ");

PrintXY(quarter);