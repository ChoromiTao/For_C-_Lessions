// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] arr = new int [123];  Решение Артемия
// Random random = new Random();
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     arr[i] = random.Next(0, 500);
//     if (arr[i] >= 10 && arr[i] < 100)
//     {  
//         count++;
//     }
// }

// foreach (var item in arr)
// {
//     Console.Write($"{item}\t");
// }
// Console.WriteLine();
// Console.WriteLine($"Количество элементов в диапазоне от 10 до 99 = {count}");

int[] GetArray()
{
    int[] array = new int[123];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-1000, 1000);
    return array;
}

int СheckingNumber(int[] array)
{
    int i = 0;
    foreach (var numb in array)
    {
        if(numb > 9 && numb <99)
        {
            i++;
        }
    }
    return i;
}

void PrintResult()
{
    Console.WriteLine("Sum of check in numbers for [10;99]: " + СheckingNumber(GetArray()));
}

int[] Array1 = GetArray();
Console.WriteLine($"Array result is {String.Join("|", Array1)}");
PrintResult();