// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
using static System.Console;

WriteLine("Введите число от 100 до 999");
int num = Convert.ToInt32(ReadLine());
if (num < 100 || num > 999) 
{
    WriteLine ("Введено неверное число");
} else {
    num = num / 10;
    num = num % 10;
    WriteLine($"Вторая цифра числа - {num}");
}
