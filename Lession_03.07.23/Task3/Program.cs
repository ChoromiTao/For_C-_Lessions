// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

int[,] doubleArr = GetArray();
ShowDuoArray(doubleArr);
int[] oneArr = ABC(doubleArr);
ShowArray(oneArr);
ShowResult(oneArr);
Console.ReadLine();

int[,] GetArray()
{
    int[,] array = new int[new Random().Next(4,6), new Random().Next(4,6)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
           array[i, j] = new Random().Next(-10, 11);
           Console.Write(array[i, j] + " ");
        }
    }
    Console.WriteLine("\n");
    return array;
}

int[] ABC(int[,] dArr)
{
    int[] oneArr = new int[dArr.GetLength(0) * dArr.GetLength(1)];
    int count = 0;

    for (int i = 0; i < dArr.GetLength(0); i++)
    {
        for (int j = 0; j < dArr.GetLength(1); j++)
        {
            oneArr[count] = dArr[i, j];
            count++;
        }
    }

    Array.Sort(oneArr);
    return oneArr;
}

void ShowArray(int[] arr) // Вывод массива на экран.
{
    Console.WriteLine("\n");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

void ShowDuoArray(int[,] arr) // Вывод массива на экран.
{
    Console.WriteLine();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
    }
}

void ShowResult(int[] arr)
{
    int element = arr[0];
    int count = 1;

    Console.WriteLine();
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] == element) count++;
        else
        {
            Console.WriteLine($"Элемент {element} встречается {count} раз.");
            element = arr[i];
            count = 1;
        }
    }
    Console.WriteLine($"Элемент {element} встречается {count} раз.");
}
