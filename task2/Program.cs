// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;

WriteLine("Введите два числа");
int a = int.Parse(ReadLine()!);
int b = int.Parse(ReadLine()!);
if(a > b) {
    WriteLine($"Число {a} является большим, число {b} является меньшим");
} else if(a < b) {
        WriteLine($"Число {b} является большим, число {a} является меньшим");
} else {
            WriteLine($"Числа {a} и {b} равны");
}