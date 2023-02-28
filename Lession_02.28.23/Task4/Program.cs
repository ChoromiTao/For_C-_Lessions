// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int N = 0;
int a = 0;
int b = 1;
int c;

int InputNumber(ref int N)
{
    Console.WriteLine("Input number for convertion: ");
    N = int.Parse(Console.ReadLine());
    return N;
}

int Fibonacci(int N)
{
    if (N == 0) 
        Console.WriteLine(a);
    else if(N == 1)
        Console.WriteLine(a + b);
    for (int i=3; i <= N; i++)
    {
        c = a+b;
        a = b;
        b = c;
        Console.WriteLine(Fibonacci(i));
    }
}

// int[] array = { 1, 2, 3, 4, 5 };     Альтернативное решение, не проверяла.

// int[] copyArray = new int[array.Length];

// for (int i = 0; i < array.Length; i++)
// {
//     copyArray[i] = array[i];
// }

// Console.WriteLine("Original array:");
// foreach (int num in array)
// {
//     Console.Write(num + " ");
// }

// Console.WriteLine("\nCopied array:");
// foreach (int num in copyArray)
// {
//     Console.Write(num + " ");
// }

// Console.WriteLine();