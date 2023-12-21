// Задача 1: 
// Задайте одномерный массив из 10 целых чисел от 1 до 100. 
// Найдите количество элементов массива, значения которых лежат в отрезке [20,90].

Console.Clear();
int[] numbers = new int[10] { 12, 36, 54, 15, 71, 92, 51, 181, 153, 150 };
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] >= 20 && numbers[i] <= 90)
    {
        count++;
    }
}
Console.WriteLine($"Количество элементов массива, значения которых лежат в отрезке [20,90]: {count}");

// Задача 2: 
// Задайте массив на 10 целых чисел. 
// Напишите программу, которая определяет количество чётных чисел в массиве.

Console.Clear();
int[] numbers = new int[10] { 12, 36, 54, 15, 71, 92, 51, 181, 153, 150 };
int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");

// Задача 3: 
// Задайте массив из вещественных чисел с ненулевой дробной частью. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();
double[] numbers = { 2.5, 4.7, 3.2, 6.1, 1.8 };
double max = numbers[0];
double min = numbers[0];
for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }

    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
double difference = max - min;
Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");