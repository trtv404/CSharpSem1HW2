// Задача 34: Напишите программу реализующую 
// методы формирования массива, заполненного случайными 
// положительными трёхзначными числами, и 
// подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

using static System.Console;

Write("Введите количество чисел в массиве ");
int a = int.Parse(ReadLine()!);

int[] array = GetArray(a);
PrintArray(array); //
Write(CountEven(array));

int[] GetArray(int array)
{
    int[] arr = new int [array];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100,1000);
    }
    return arr;
}

int CountEven(int[] arr) 
{
    int count = 0;
    foreach (int a in arr)
    {
        if (a % 2 == 0) count++;
    }
    return count;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}