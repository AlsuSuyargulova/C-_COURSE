﻿// Console.Clear();
// Console.Write("Введите число: ");
// int s = Convert.ToInt32(Console.ReadLine());
// // s = "5"
// Console.WriteLine(s + 5);
// Console.WriteLine(s);

// Напишите программу, которая на вход 
// принимает два целых числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 => да
// a = 2, b = 10 => нет
// a = 9, b = - 3 => да
// a = - 3, b = 9 => нет

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a == b*b)
// {
//     Console.WriteLine("yes");
// }
// else
// {
//     Console.WriteLine("no");
// }

// ---------------------------------------------------------------------------------------

// напишиет программу, которая на вход принимает
// целое чилсо N, а на выходе показывает все целые числа
// чила в промежутке от -N до N.
// Прмеры:
// 4 => -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 => -2, -1, 0, 1, 2

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int i = n * (-1);
// while (i <= n)
// {
//     Console.Write(i);
//     i ++;
// }

//-------------------------------------------------------------------------

// Напишите программу, которая на вход 
// принимает трехзначное число и на выходе показывает сумму
// первой и последней цифры этого числаю
// 456 => 10
// 782 => 9
// 918 => 17

// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int n1 = n / 100; //456 / 100 => 4 (55 ost) = 4
// int n3 = n % 10; //456 / 10 => 45 (6 ost) = 6
// Console.WriteLine(n1 + n3);

//-------------------------------------------------------------------------

// Внутри класса Answer напишите метод CompareNumbers, 
// который на вход принимает два числа и выводит, 
// какое число большее, а какое меньшее.

// Console.Clear();
// Console.Write("Введите число: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if (a > b)
// {
//     Console.WriteLine(a);
// }
// else
// {
//     Console.WriteLine(b);
// }

//-------------------------------------------------------------------------

// Внутри класса Answer напишите метод FindMax, 
// который принимает на вход три числа 
// и выдаёт максимальное из этих чисел.

// int max = a;
// if (max < b)
// {
//     max = b;
// }
// if (max < c)
// {
//     max = c;
// }
// return max;

//-------------------------------------------------------------------------

// Внутри класса Answer напишите метод CheckIfEven, 
// который на вход принимает число number и выводит, 
// является ли число чётным (делится ли оно на два без остатка).

// if ((number % 2) == 0)
// {
//     Console.WriteLine($"Число `{number}` чётное");
// }
// else
// {
//     Console.WriteLine($"Число `{number}` нечётное");
// }
// }

//-------------------------------------------------------------------------

// Внутри класса Answer напишите метод PrintEvenNumbers, 
//которая на вход принимает число (number), 
// а на выходе выводит все чётные числа 
// от 1 до number (включительно), разделеные знаком табуляции.

// static void PrintEvenNumbers(int number)
// {
//     for (int count = 2; count <= number; count += 2)
// {
//         Console.Write($"{count}\t");
//     }
// }
// ХЗ не работает
// static void PrintEvenNumbers(int number)
// {
//     for (int count = 2; count <= number; count += 2)
//     {
//         Console.Write($"{count}\t");
//     }
// }
// PrintEvenNumbers(number);