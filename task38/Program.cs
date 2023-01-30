// Задача 38: Напишите программу реализующую методы формирования 
// массива, заполненного случайными вещественными числами и 
// вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

Write("Введите количество чисел в массиве: ");
int length = int.Parse(ReadLine()!);
Write("Введите минимальное значение чисел (от ...): ");
double minValue = Convert.ToDouble(ReadLine());
Write("Введите минимальное значение чисел (до ...): ");
double maxValue = Convert.ToDouble(ReadLine());

double[] array1 = GetArray(length);
PrintArray(array1);
Write(Subsruction(array1));

double[] GetArray(int array)
{

    double[] arr = new double [array];
    for (int i = 0; i < arr.Length; i++)
    {
        Random rnd = new Random();
        // arr[i] = rnd.NextDouble(minValue, maxValue);
        arr[i] = Math.Round(minValue + rnd.NextDouble() * (maxValue - minValue), 2);
    } 
    return arr;
}

double Subsruction(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < min) min = arr[i];
            if (arr[i] > max) max = arr[i];
        }
        WriteLine(min); // не нужно, но чтобы не искать в массиве самому
        WriteLine(max); // не нужно, но чтобы не искать в массиве самому

        return max - min;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{arr[i]} ");
    }
    WriteLine();
}