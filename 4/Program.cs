// Задача 4 По заданному с клавиатуры номеру дня недели вывести его название

string mon = "Понедельник";
string thu = "Вторник";
string when = "Среда";
string firth = "Четверг";
string fri = "Пятница";
string sat = "Суббота";
string sun = "Воскресенье";

Console.WriteLine("Введите номер дня недели: ");
string number = Console.ReadLine();
if(number == "1") Console.WriteLine(mon);
if(number == "2") Console.WriteLine(thu);
if(number == "3") Console.WriteLine(when);
if(number == "4") Console.WriteLine(firth);
if(number == "5") Console.WriteLine(fri);
if(number == "6") Console.WriteLine(sat);
if(number == "7") Console.WriteLine(sun);