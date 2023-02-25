// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

//Решение Артемия

int [] arr = {1, 2, 3, 4, 5};
int [] arr2;

if (arr.Length % 2 != 0)
{
    arr2 = new int [arr.Length / 2 + 1];
    arr2 [arr.Length / 2] = arr[arr.Length / 2];
}
else
{
arr2 = new int [arr.Length / 2];
}

for (int i = 0, j = arr.Length - 1; i < arr.Length / 2; i++, j--)
{
    arr2[i] = arr[i] * arr [j];
}

foreach (var item in arr)
{
    Console.Write(item + " ");
}

Console.WriteLine();

foreach (var item in arr2)
{
    Console.Write(item + " ");
}