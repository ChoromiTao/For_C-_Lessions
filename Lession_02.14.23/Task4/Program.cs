// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно


Console.WriteLine("Введите 2 числа");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

if(a>b && a % b == 0)
{
    Console.WriteLine("Число " + a + " кратно числу " + b);
}
else if (a>b && a % b != 0)
{
    Console.WriteLine($"Число {a} не кратно числу {b} Остаток {a % b}");
}
else if(b>a && b % a == 0)
{
    Console.WriteLine($"Число {b} кратно числу {a}");
}
else if (b>a && b % a != 0)
{
    Console.WriteLine($"Число {b} не кратно числу {a}. Остаток {b % a}");
}