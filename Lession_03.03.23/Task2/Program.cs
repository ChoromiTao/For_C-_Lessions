﻿// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] array = new int[new Random().Next(2,10), new Random().Next(2,10)];

for (int i = 0; i < array.GetLength(0); i++)
{
    Console.WriteLine();
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = i+j;
        Console.Write(array[i, j] + " ");
    }
}

// Альтернативное решение через ручной ввод значений строк и столбцов

// Console.WriteLine("Введите количество строк: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество столбцов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int[m,n];
// for (int i = 0; i < array.GetLength(0); i++)
// {
//     Console.WriteLine();
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//         array[i, j] = i + j;
//         Console.Write(array[i, j] + " ");
//     }
// }