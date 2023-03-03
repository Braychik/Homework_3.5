/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();
double [] n = GetRandomArray(5, 0, 10);
Console.WriteLine(String.Join(", ", n));
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {MinMaxDifference(n)}");

 double [] GetRandomArray(int size, int minValue, int maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1));
    }
    return result;
}

double MinMaxDifference(double [] array)
{
    double diff = 0;
    double max = array[0];
    double min = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        if(max < array[i])
        max = array[i];
        if(min > array[i])
        min = array[i];
        diff = max - min;
    }
    return diff;
}