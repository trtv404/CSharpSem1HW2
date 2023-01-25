//Задача 27: Напишите программу, реализующую метод,
// который принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

using static System.Console;

Write("input a number ");
int number = int.Parse(ReadLine()!);

int sum = GetSum(number);

WriteLine($"Sum of numbers = {sum}");

int GetSum(int a) {

int div = 10;
int mod = 0;
int result = 0; 
if (a < 0) a = a * -1;
while (a > 0) {
    mod = a % div;
    result = result + mod;
    a = a / div;
    }
return result;
}
