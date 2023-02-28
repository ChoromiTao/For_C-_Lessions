//  Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

int[] CopyArray(int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        arrayCopy[i] = array[i];
    return arrayCopy;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

int[] array = GenerateArray(10);
PrintArray(array);
PrintArray(CopyArray(array));
Console.WriteLine(array == array);
Console.WriteLine(array == CopyArray(array));