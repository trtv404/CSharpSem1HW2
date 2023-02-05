// Задача 68: Напишите программу реализующую метод 
// вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

using static System.Console;

Write("Введите два неотрицательных числа через пробел: ");
string[] inPut = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int number1 = int.Parse(inPut[0]); 
int number2 = int.Parse(inPut[1]);
WriteLine(Ack(number1, number2));

int Ack(int num1, int num2)
{
    if (num1 == 0) return (num2 + 1);
    else if (num2 == 0) return Ack (num1-1, 1);
    else return Ack(num1-1, Ack(num1, num2-1));
}
