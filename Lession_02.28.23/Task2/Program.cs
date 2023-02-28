// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int a = 0;
int count = 0;
int[] array = new int[count];

int InputNumber(ref int a)
{
    Console.WriteLine("Input number for convertion: ");
    a = int.Parse(Console.ReadLine());
    return a;
}

int ForCount(ref int count, int a)
{
    for (int i = 0; a > 0; i++)
    {
        a /= 2;
        count ++;
    }
    return count;
}

int[] Conversation(int a, int count)
{
    while (a>0)
    {
        int[] array = new int[count];
        a = a / 2;
        array[count-1] = a%2;
    }
    return array;
}

InputNumber(ref a);
ForCount(ref count, a);
Conversation(a, count);
Console.WriteLine("Number is an dual system: " + (string.Join(" ", array)));