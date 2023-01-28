// Задача 36: Напишите программу реализующую методы 
// формирования массива, заполненного случайными числами и 
// подсчета суммы элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
using static System.Console;


Write("Введите количество чисел в массиве: ");
int length = int.Parse(ReadLine()!);

int[] array1 = GetArray(length);
PrintArray(array1);
Write(CountSum(array1));


int[] GetArray(int array)
{
    Write("Введите минимальное значение чисел (от ...): ");
    int minValue = int.Parse(ReadLine()!);
    Write("Введите минимальное значение чисел (до ...): ");
    int maxValue = int.Parse(ReadLine()!);

    int[] arr = new int [array];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue +1 );
    }
    return arr;
}

int CountSum(int[] array)
{
    int count = 0;
        for(int i = 1; i < array.Length; i = i +2)
        {
            count = count + array[i];
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