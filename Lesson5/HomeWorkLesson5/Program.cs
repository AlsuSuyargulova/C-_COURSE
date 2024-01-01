// Задача 1: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;

class Program
{
    static int GetElementValue(int[, ] array, int x, int y)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        
        if (x >= rows || y >= columns)
        {
            Console.WriteLine("Указанные координаты вне диапазона массива.");
            return -1;
        }
        else
        {
            return array[x, y];
        }
    }

    static void Main()
    {
        int[, ] myArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        
        Console.Write("Введите позицию элемента по горизонтали: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Введите позицию элемента по вертикали: ");
        int y = int.Parse(Console.ReadLine());
        
        int result = GetElementValue(myArray, x, y);
        Console.WriteLine("Значение элемента: " + result);
    }
}