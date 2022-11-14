// Задача 3 С клавиатуры вводятся два числа a и b. Найти максимальное из них
Console.WriteLine("Введите число а: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число в: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a > b) Console.WriteLine(a);
else Console.WriteLine(b);
