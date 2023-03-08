// Задача 53: Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


int[,] array = new int[4, 4];

int[,] GetArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = new Random().Next(-10, 11);
           Console.Write(array[i, j] + " ");
        }
    }
    return array;
}

void ReturnStringsArray(int[,] array)
{
    for (int i = 0, temp = 0; i < array.GetLength(0); i++)
    {
        temp = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = array[0,i];
        array[0,i] = temp;
    }
}

void ShowArray(int[,] array) // Вывод массива на экран.
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    }
}

array = GetArray();
ReturnStringsArray(array);
ShowArray(array);