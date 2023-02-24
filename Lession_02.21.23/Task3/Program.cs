// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Random number = new Random();
int[] arr = new int [8];
for (int i = 0; i < arr.length; i++)
{
    arr[i] = random.Next(0,2);
    string array = String.Join("   ", arr);
    Console.WriteLine(array);
}
