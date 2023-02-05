// Задача 66: Напишите программу, которая реализует 
// рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;

Write("Введите два числа через пробел: ");
string[] inPut = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int number1 = int.Parse(inPut[0]); 
int number2 = int.Parse(inPut[1]);
WriteLine(GetSum(number1, number2));

int GetSum (int num1, int num2){
    if (num1 == num2) return num1;
    else if (num1 < num2) return (GetSum(num1, num2 - 1) + num2);
    else return (GetSum(num1 - 1, num2) + num1);
}