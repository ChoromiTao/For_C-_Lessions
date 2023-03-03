// Задача 50: Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите искомое число: ");
int ViewerNumber = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[new Random().Next(10,15), new Random().Next(10,15)];

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {  
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + " ");
        }
    }   
}

void Viewer(int[,] array, int ViewerNumber)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j] == ViewerNumber)
            {
                Console.WriteLine($"Искомый элемент находится на позиции: {i}, {j}");
            }
            else
                {
                    count++;
                }
        }
    }
    if (count == array.GetLength(0)*array.GetLength(1))
        Console.WriteLine("Искомого значения нет!");
}

FillArray(array);
Console.WriteLine();
Viewer(array, ViewerNumber);