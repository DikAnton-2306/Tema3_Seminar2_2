// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
int DataEntry(string str)
{
    Console.Write(str);
    int n = int.Parse(Console.ReadLine());
    return n;
}

void Result(int n)
{
    int index = 1;
    while (index <= n - 1)
    {
        Console.Write(index * index + ", ");
        index++;
    }
    Console.Write(index * index);
}

int number = DataEntry("Введите число ");
Result(number);