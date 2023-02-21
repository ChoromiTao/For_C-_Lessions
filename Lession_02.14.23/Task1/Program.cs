// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// (0,5) - не включают кайние числа
// [] - чсла включаются все
Random createNumber = new Random();
int number = createNumber.Next(10,100);
// соответсвенно Next(10,99) включаетв диапазон 10, но не включает 99! то есть [10,99)

int a = number / 10;
int b = number % 10;

if (a>b)
    Console.WriteLine("Первая цифра больше второй");
else if (a<b)
    Console.WriteLine("Вторая цифра " + b + " больше первой " + a);
else 
    Console.WriteLine($"Цифры равны {a} == {b}");

// Console.WriteLine("text example" + a);
// Console.WriteLine("text {0} example {1}" + b,a);
// Console.WriteLine($"text {a} example {b}");