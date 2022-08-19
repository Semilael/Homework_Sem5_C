// // Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetArray(int size, int min, int max)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", result)}]");
    return result;
}

double[] array = GetArray(20, 0, 100);

double maxNumber = array[0];
double minNumber = array[0];

  for (int i = 1; i < array.Length; i++)
  {
    if (maxNumber < array[i])
    {
      maxNumber = array[i];
    }
        if (minNumber > array[i])
    {
      minNumber = array[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nРазница между между максимальным ({maxNumber}) и минимальным ({minNumber}) элементами равна {decision}.");