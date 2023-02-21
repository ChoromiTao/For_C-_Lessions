// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

Console.WriteLine("Введите число от 1 до 4");

    int quarter = Convert.ToInt32(Console.ReadLine());

switch (quarter)
{
    case 1: 
        System.Console.WriteLine("x > 0; y >0");
        break;
    case 2: 
        System.Console.WriteLine("x < 0; y > 0");  
        break;      
    case 3: 
        System.Console.WriteLine("x < 0; y < 0");
        break;
    case 4: 
        System.Console.WriteLine("x > 0; y < 0");
        break;
    default: 
        System.Console.WriteLine("Такой координатной плоскости не существует!");
        break;
}
