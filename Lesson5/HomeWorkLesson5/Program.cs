// Задача 1: 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// using System;

// class Program
// {
//     static int GetElementValue(int[, ] array, int x, int y)
//     {
//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         if (x >= rows || y >= columns)
//         {
//             Console.WriteLine("Указанные координаты вне диапазона массива.");
//             return -1;
//         }
//         else
//         {
//             return array[x, y];
//         }
//     }

//     static void Main()
//     {
//         int[, ] myArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

//         Console.Write("Введите позицию элемента по горизонтали: ");
//         int x = int.Parse(Console.ReadLine());

//         Console.Write("Введите позицию элемента по вертикали: ");
//         int y = int.Parse(Console.ReadLine());

//         int result = GetElementValue(myArray, x, y);
//         Console.WriteLine("Значение элемента: " + result);
//     }
// }


// Задача 2: 
// Задайте двумерный массив. 
// Напишите программу, которая поменяет местами первую и последнюю строку массива.

// using System;

// class Program
// {
//     static void Main()
//     {
//         // Создаем двумерный массив
//         int[,] array = {
//             {1, 2, 3},
//             {4, 5, 6},
//             {7, 8, 9}
//         };

//         Console.WriteLine("Исходный массив:");
//         PrintArray(array);

//         // Меняем местами первую и последнюю строку
//         SwapRows(array, 0, array.GetLength(0) - 1);

//         Console.WriteLine("Массив после замены строк:");
//         PrintArray(array);
//     }

//     static void SwapRows(int[,] array, int row1, int row2)
//     {
//         int columns = array.GetLength(1);

//         for (int i = 0; i < columns; i++)
//         {
//             int temp = array[row1, i];
//             array[row1, i] = array[row2, i];
//             array[row2, i] = temp;
//         }
//     }

//     static void PrintArray(int[,] array)
//     {
//         int rows = array.GetLength(0);
//         int columns = array.GetLength(1);

//         for (int i = 0; i < rows; i++)
//         {
//             for (int j = 0; j < columns; j++)
//             {
//                 Console.Write(array[i, j] + " ");
//             }
//             Console.WriteLine();
//         }
//     }
// }

// Задача 3: 
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System;

class Program
{
    static void Main()
    {
        // Создаем прямоугольный двумерный массив
        int[,] array = {
            {1, 2, 3},
            {4, 5, -6},
            {7, -8, 9},
            {-1, -2, -3}
        };

        Console.WriteLine("Исходный массив:");
        PrintArray(array);

        // Находим строку с наименьшей суммой элементов
        int minRow = FindMinRow(array);

        Console.WriteLine("Строка с наименьшей суммой элементов: {0}", minRow);
    }

    static int FindMinRow(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);
        int minRow = 0;
        int minSum = int.MaxValue; // Инициализируем минимальную сумму максимальным значением int

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;

            for (int j = 0; j < columns; j++)
            {
                sum += array[i, j];
            }

            if (sum < minSum)
            {
                minSum = sum;
                minRow = i;
            }
        }

        return minRow;
    }

    static void PrintArray(int[,] array)
    {
        int rows = array.GetLength(0);
        int columns = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}