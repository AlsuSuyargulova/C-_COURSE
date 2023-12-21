Задача 1: 
Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.

Console.Clear();
Console.Write("Введите чило: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 7 == 0 && n % 23 == 0)
    Console.WriteLine("Да!");
else
    Console.WriteLine("Нет!");

Задача 2: 
Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, 
в которой находится эта точка.

Console.Write("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки Y: ");
int y = Convert.ToInt32(Console.ReadLine());
if (x > 0 && y > 0)
Console.WriteLine("1");
if (x < 0 && y > 0)
Console.WriteLine("2");
if (x < 0 && y < 0)
Console.WriteLine("3");
if (x > 0 && y < 0)
Console.WriteLine("4");
else
Console.WriteLine("Точка находится на оси координат");

Задача 3: 
Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
и показывает наибольшую цифру числа.

Console.Clear();
Console.Write("Введите число: "); // 45
int n = Convert.ToInt32(Console.ReadLine());
if (n > 9 && n < 100)
{
    int a = n / 10; // 45 / 10 -> 4 (5 ost) = 4
    int b = n % 10; // 45 % 10 -> 4 (5 ost) = 5
    int max = a;
    if (max < b)
        max = b;
    if (max > b)
        max = a;
Console.WriteLine(max);
}
else
    Console.WriteLine("Не входит в указанный отрезок чисел!");

Задача 4: 
Напишите программу, которая на вход принимает натуральное число N, 
а на выходе показывает его цифры через запятую.

Console.Clear();
Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N < 10)
    Console.WriteLine(N);
else
{
    while (N > 0)
    {
        int currentDigit = N % 10;
        N /= 10;
        if (N > 0)
            Console.Write(currentDigit + ",");
        else
            Console.WriteLine(currentDigit);
    }
}