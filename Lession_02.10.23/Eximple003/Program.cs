// Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 3 -> Среда 
// 5 -> Пятница
Console.WriteLine("Input number");
int a = Convert.ToInt32(Console.ReadLine());
int c = 5;
switch (a)
{
case 1:
string output = "Monday";
Console.WriteLine(output);
break;
case 2:
Console.WriteLine("Tuesday");
break;
case 3:
Console.WriteLine("Wednesday");
break;
case 4:
Console.WriteLine("Thursday");
break;
case 5:
Console.WriteLine("Friday");
break;
case 6:
Console.WriteLine("Saturday");
break;
case 7:
Console.WriteLine("Sunday");
break;
default:
Console.WriteLine("There is no such a weekday");
break;
}