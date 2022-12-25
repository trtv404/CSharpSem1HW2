// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
using static System.Console;

Write("Точка А, координата X:");
int ax = int.Parse(ReadLine()!);
Write("Точка А, координата Y:");
int ay = int.Parse(ReadLine()!);
Write("Точка А, координата Z:");
int az = int.Parse(ReadLine()!);
Write("Точка В, координата X:");
int bx = int.Parse(ReadLine()!);
Write("Точка В, координата Y:");
int by = int.Parse(ReadLine()!);
Write("Точка В, координата Z:");
int bz = int.Parse(ReadLine()!);

double length = Math.Sqrt(Math.Pow((ax - bx), 2) + Math.Pow((ay - by), 2) + Math.Pow((az - bz), 2));
WriteLine($"Длина отрезка = {length:f2}");
