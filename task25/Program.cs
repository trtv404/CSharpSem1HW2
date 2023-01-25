// Задача 25: Напишите программу, реализующую метод,
// который принимает на вход два числа (A и B) и возводит число A 
// в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
using static System.Console;

Write("input first number ");
int a = int.Parse(ReadLine()!);
Write("input second number ");
int b = int.Parse(ReadLine()!);

int pow = GetPow(a,b);

WriteLine($"{a} to the power of {b} = {pow}");

int GetPow(int num1, int num2)
{
    int result = 1;
    for (int i = 0; i < num2; i++) 
        {
        result = result * num1;  
        }
        return result;
    }    
        

