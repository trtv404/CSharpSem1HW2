// Задача 29: Напишите программу, реализующую метод, 
// который формирует массив случайных целых чисел 
// из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]
using static System.Console;

int[] array = GetArray(8);
PrintArray(array);


int[] GetArray(int size)
{
    Write("Введите начало диапазона чисел ");
    int a = int.Parse(ReadLine()!);
    Write("Введите конец диапазона числел ");
    int b = int.Parse(ReadLine()!);
    int[] arr = new int [size];

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(a, b+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}
