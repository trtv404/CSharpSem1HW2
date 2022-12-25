// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
using static System.Console;

WriteLine("Введите число");
bool isParse = int.TryParse(ReadLine(), out int n);
if (!isParse) {
    WriteLine("Введено неверное значение");
    return;
}

int i = 1;
while (i <= n) 
{
    WriteLine($"Кубом числа {i} является {Math.Pow(i,3)}");
    i++;
}