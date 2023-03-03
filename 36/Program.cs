/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();
int[] n = GetRandomArray(10, -10, 10);
Console.WriteLine(String.Join(", ", n));
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {SumNegativeNums(n)}");

 int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int  SumNegativeNums(int [] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 0)
        summ += array[i];
    }
    return summ;
}