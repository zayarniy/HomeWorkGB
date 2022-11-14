// Задача 8 Вывести на экран числа от -N до N

Console.WriteLine("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());
int index = 0;
int value = 0;
while(index < n){
    index = n + (value - n * 2);
    Console.Write(index + " ");
    value++;
}