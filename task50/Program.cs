// Задача 50. Напишите программу реализующую метод,принимающий позиции 
// элемента в двумерном массиве, и возвращающий значение этого элемента или 
// же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(matrix);
WriteLine(isExist(matrix));

int[,] GetMatrixArray(int rows, int columns, int minValue, int maxValue)
{
        int[,] resultArray = new int[rows, columns];

    for (int i = 0; i<rows; i++)
    {
        for (int j = 0; j< columns; j++)
        {
            Random rnd = new Random();
            resultArray[i,j] = rnd.Next(minValue, maxValue+1);
        }
    }
    return resultArray;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],3} "); 
        }
        WriteLine();
    }
}

string isExist(int[,] inArray)
{
    string res = new string ("");
    Write("Введите индекс искомого элемента: ");
    string[] find = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int i = int.Parse(find[0]);
    int j = int.Parse(find[1]);
    
    res = (i > inArray.GetLength(0) || j > inArray.GetLength(1) ? "такого элемента в массиве нет" : $"значение элемента = {inArray[i,j]}"); 
return res;
}