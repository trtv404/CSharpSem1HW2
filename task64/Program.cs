// Задача 64: Напишите программу, которая реализует рекурсивный 
// метод вывода всех натуральных числел в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
using static System.Console;
Write("Введите число: ");
int number = int.Parse(ReadLine()!);
PrintNumbers(number);

void PrintNumbers(int num)
{
    if (num < 1) Write("неверное число");
    if (num == 1) Write(num);
    else
    {
        Write($"{num}, ");
        PrintNumbers(num - 1);
    }
}


