// Демонстрация решения
// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GenerateArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(-10, 11);
    return array;
}

int[] ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int tmp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = tmp;
    }
    return array;
}

int[] AnotherReverseArray(int[] array)
{
    int[] tmpArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
        tmpArray[i] = array[array.Length - 1 - i];
    return tmpArray;
}

void PrintArray(int[] array)
{
    Console.WriteLine(String.Join(" ", array));
}

int[] array = GenerateArray(10);
PrintArray(array);
PrintArray(AnotherReverseArray(array));
PrintArray(ReverseArray(array));