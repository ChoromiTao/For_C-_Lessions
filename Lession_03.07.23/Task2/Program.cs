// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


int[,] array = new int[new Random().Next(4,6), new Random().Next(4,6)];

int[,] GetArray()
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
    Console.WriteLine("\n");
    return array;
}


int[,] ChangeRowsWithColumns(int[,] array)
{
  int m = array.GetLength(0);
  int n = array.GetLength(1);

  int[,] newArray = new int[m, n];

  if (m != n)
    System.Console.WriteLine("Массив не подходит!!!");
  else
  {
    for (int i = 0; i < m; i++)
    {
      for (int j = 0; j < n; j++)
      {
        newArray[i,j] = array[j,i];
      }
    }
  }
  return newArray;
}

void ReadArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      System.Console.Write("{0:d2} ", array[i, j]);
    }
    System.Console.WriteLine();
  }
}

array = GetArray();
ReadArray(ChangeRowsWithColumns(array));