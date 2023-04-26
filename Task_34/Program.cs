﻿//Задайте массив заполненный случайными положительными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345,897,568,234]->2
Console.Clear();
int numb = 0;
int [] array = GetArray(4, 100, 999);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(CheckArrayForNumber(array, numb));

//--------------------------------------------------- 

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int CheckArrayForNumber(int[] array, int numb)
{
    int count = 0;
    foreach (int number in array)
    {
        if (number % 2 == 0)
        {
        count++;
        }
    }
    return count;
}
