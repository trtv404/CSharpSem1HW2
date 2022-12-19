// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
using static System.Console;

WriteLine("Введите число");
int a = int.Parse(ReadLine()!);
int b = 1;
WriteLine($"четные числа в диапазоне от 1 до {a}:");

while(b <= a) {
    if(b % 2 == 0) {
        WriteLine(b);
    }
    b +=1;
}