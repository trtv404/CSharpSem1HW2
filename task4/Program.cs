// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
using static System.Console;

WriteLine("Введите три числа");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
int c = int.Parse(ReadLine()!);
if(a >= b && a >= c) {
    WriteLine($"Число {a} является наибольшим");
}
else if(b >= a && b >=c) {
    WriteLine($"Число {b} является наибольшим");
}
else {
    WriteLine($"Число {c} является наибольшим");
}