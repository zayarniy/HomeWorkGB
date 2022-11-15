// Задача 8 Вывести на экран числа от -N до N

Console.WriteLine("Введите число N: ");

int n = Convert.ToInt32(Console.ReadLine());
int index = -n;

while(index <= n){
    index++;
    Console.Write(index + " ");
    
}
