//Задача 34: Задайте массив заполненный 
// случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел 
//в массиве.
// [345, 897, 568, 234] -> 2

// методы
int[] CreateArraeRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int EvenNumbers(int[] arr)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) result++;
    }
    return result;
}

int[] array = CreateArraeRndInt(4, 100, 1000);
PrintArray(array);
int result = EvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве = {result}");
