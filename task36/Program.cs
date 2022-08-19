// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", result)}]");
    return result;
}

int[] writeArray = GetArray(20, 0, 99);

int SumI(int[] array)
{
    int sum = 0;
    foreach (int i in array)
    {
        for(int j = 1; j < 20; j += 2)
        {
            sum += array[j];
        }
        break;
    }
    return sum;
}

Console.WriteLine($"Сумма нечетных элементов массива: {SumI(writeArray)}");