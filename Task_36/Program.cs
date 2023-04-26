//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
Console.Clear();
int[] array = GetArray(4, 1, 100);
Console.WriteLine(String.Join(" ", array));
Console.WriteLine(SumArrayNumbers(array));

//---------------------------------------------------------

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int SumArrayNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i +=2)
    {
        sum += array[i];
    }
    return sum;
}

//----------------------------------------------------------