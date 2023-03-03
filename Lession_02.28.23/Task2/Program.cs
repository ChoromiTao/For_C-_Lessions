// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

// int a = 0;      //моё решение работать не хочет! Проблема в 33 и 40 строчках!
// int count = 0;

// int InputNumber(ref int a)
// {
//     Console.WriteLine("Input number for convertion: ");
//     a = Convert.ToInt32(Console.ReadLine());
//     return a;
// }

// int ForCount(ref int count, int a)
// {
//     for (int i = 0; a > 0; i++)
//     {
//         a /= 2;
//         count ++;
//     }
//     return count;
// }

// int[] Conversation(int a, ref int[] array)
// {
//     int b;
//     for (int i = 0; a>0; i++)
//     {
//         a = a / 2;
//         b = a%2;
//         array[i] = b;
//     }
//     return array;
// }
// int[] array = new int[count];
// InputNumber(ref a);
// ForCount(ref count, a);
// Conversation(a, ref array);
// Console.WriteLine("Number is an dual system: " + (string.Join(" ", array)));

// The end of my code


Console.WriteLine("Enter a number: ");
int dec = int.Parse(Console.ReadLine());

string bin = "";

while (dec >0)
{
    bin = (dec % 2).ToString() + bin;
    dec/=2;
}

Console.WriteLine("Binary: {0}", bin);