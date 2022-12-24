// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
using static System.Console;

WriteLine("Введите любое число");
int num = Convert.ToInt32(ReadLine());
if (num < 100) {
WriteLine("Третьей цифры нет");
} else {
num = num / 100;
num = num % 10;
WriteLine($"Третья цифра - {num}");
}