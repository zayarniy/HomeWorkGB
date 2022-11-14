// Задача 5 С клавиатуры вводятся три числа. Найти максимальное из трех чисел
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число в: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if(a > b && a > c) Console.WriteLine(a);
if(b > a && b > c) Console.WriteLine(b);
if(c > a && c > b) Console.WriteLine(c);
