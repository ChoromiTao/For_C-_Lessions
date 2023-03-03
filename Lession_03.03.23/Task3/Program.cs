// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] array = new int[new Random().Next(2,10), new Random().Next(2,10)];

void FillArray(int[,] array)
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
}

void Exploer(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i%2 == 0 && j%2 == 0)
            {
                array[i,j] *= array[i,j];
            }
        Console.Write(array[i, j] + " ");
        }
    }
}

FillArray(array);
Console.WriteLine();
Exploer(array);