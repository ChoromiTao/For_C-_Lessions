// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a == b*b)
{
    Console.WriteLine("Число " + a + " является квадратом " + b);
}
else if (b == a*a)
{
    Console.WriteLine("Число " + b + " является квадратом " + a);
}
else Console.WriteLine("Числа " + a + " и " + b + " не являются квадратами друг другу");