// задача 32: Напишите программу замена элементов массива: положительные элементы заменить на отрицательные и наоборот

int[] arrayResult = new int[12];

int[] GetArray()
{
    int[] arrayResult = new int[8];
    for (int i = 0; i < arrayResult.Length; i++)
        arrayResult[i] = new Random().Next(-9, 10);
    return arrayResult;
}

void ReverseArray(int[] arrayResult)
{
    for (int i = 0; i < arrayResult.Length; i++)
    {
        arrayResult[i] *= -1;
    }
}

void PrintResult(int[] arrayResult)
{
    Console.WriteLine($"Array result is {String.Join("|", arrayResult)}");
}

arrayResult = GetArray();
Console.WriteLine(String.Join("|",arrayResult));
ReverseArray(arrayResult);
PrintResult(arrayResult);