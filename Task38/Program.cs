// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

// методы

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
       arr[i]=Math.Round((rnd.NextDouble() * (max - min) + min) ,2,MidpointRounding.ToZero);
        //arr[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double MinNumber(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double MaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}
double[] array = CreateArrayRndDouble(6, -100, 100);
PrintArrayDouble(array);
double max = Math.Round( MaxNumber(array),2,MidpointRounding.ToZero);
double min = Math.Round( MinNumber(array),2,MidpointRounding.ToZero);
double difference = Math.Round((max-min),2,MidpointRounding.ToZero);
Console.WriteLine();
Console.WriteLine($"Разница между {max} и {min} равна {difference}");
