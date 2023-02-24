// Демонстрация решения
// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Sum(5);
// Console.WriteLine(Sum);


//int number = GetNumber();
//Console.WriteLine("Sum is {0}", Sum(number));


// int GetNumber()
// {
//     Console.WriteLine("Input number: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     return number;
// }

// int Sum(int a)
// {
//     int result = 0;
//     for (int i = 1; i <= a; i++)
//     {
//         Console.Write(i + "");
//         result += i;
//     }
//     return result;
// }

int number = GetNumber();
Console.WriteLine("Sum is {0}", Sum(number));


int GetNumber()
{
    Console.WriteLine("Input number:");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int Sum(int a)
{
    int result = 0;
    for (int i = 1; i <= a; i++)
    {
        Console.Write(i + " ");
        result += i;
    }
    return result;
}