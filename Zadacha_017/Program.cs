// Задача 17. Принимает координаты точки (X<>0, Y<>0) и выдаёт номер четверти плоскости, где находится точка.
Console.Clear();

int DataEntryXY (string str)
{
    Console.Write(str);
    //int number = Convert.ToInt32(Console.ReadLine());
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FindQvadnrant (int x, int y)
{
    if(x > 0 && y > 0) 
        Console.WriteLine("Это первый квадрат");
    if(x < 0 && y > 0) 
        Console.WriteLine("Это второй квадрат");
    if(x < 0 && y < 0) 
        Console.WriteLine("Это третий квадрат");
    if(x > 0 && y < 0) 
        Console.WriteLine("Это четвертый квадрат");
}

int x =  DataEntryXY("Введите кординаты X = ");
int y =  DataEntryXY("Введите кординаты Y = ");

FindQvadnrant(x,y);