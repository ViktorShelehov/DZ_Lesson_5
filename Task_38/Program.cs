//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элемнтом массива.
Console.Clear();
Random rand = new Random();
int length = rand.Next(1, 5);


double[] arr = new double[length];

for (int i = 0; i < length; i++)
{
    arr[i] = rand.NextDouble() * 10 - 5;
}
double min = arr[0], max = arr[0]; 
for (int i = 1; i < length; i++) 
{
    if (arr[i] < min) min = arr[i]; 
    if (arr[i] > max) max = arr[i]; 
}
double diff = max - min;
Console.WriteLine("Массив: [{0}]", string.Join(", ", arr));
Console.WriteLine("Разница между максимальным и минимальным элементом: {0}", diff);
