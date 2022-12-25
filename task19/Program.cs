// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
using static System.Console;

WriteLine("Введите пятизначной число");
int num = Convert.ToInt32(ReadLine());
if (num < 10000 || num > 99999)
 {
WriteLine("Введено неверное число");
return;
}
int num1 = num / 10000;
int num2 = num / 1000 % 10;
int num4 = num / 10 % 10;
int num5 = num % 10;

WriteLine(num1 == num5 && num2 == num4 ? "Число является полиндромом" : "Число не является полиндромом");