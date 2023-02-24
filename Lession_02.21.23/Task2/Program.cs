// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120


int GetNumber()
{
    Console.WriteLine("Input number:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Numbers()
{
    int a = GetNumber();
    int count = 0;
    while (a >0)
    {
        a = a / 10;
        count ++;
    }
    return count;
}

int Result()
{
    int b = GetNumber();
    int x = 1;
    for (int i = 1; i <= b; i++)
    {
        x = x*i;
    }
    return x;
}

Console.WriteLine(Result());