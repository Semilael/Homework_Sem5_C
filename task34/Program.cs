// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetArray(int size, int min, int max)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(min, max + 1);
    }
    Console.WriteLine($"Массив: [{string.Join(", ", result)}]");
    return result;
}

int[] array = GetArray(20, 100, 999);

int Check(int[] somearray)
{
    int even = 0;
    foreach(int j in somearray)
    {
        
        if(j % 2 == 0) 
        {
            even++;
        }
          
    }
    return even;
    
}

Console.WriteLine($"В массиве {Check(array)} четных чисел.");