// Задача 52. Напишите программу реализующую методы, 
// формирования двумерного массива и массива средних 
// арифметических значений каждого столбца.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 
// 4,6; 5,6; 3,6; 3.

using static System.Console;

Write("Введите размер матрицы и диапазон значений через пробел: ");
string[] parameters = ReadLine()!.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,] matrix = GetMatrixArray(int.Parse(parameters[0]), int.Parse(parameters[1]),int.Parse(parameters[2]),int.Parse(parameters[3]));
PrintMatrixArray(matrix);
WriteLine();
// WriteLine(AverageOfColumns(matrix));
AverageOfColumns(matrix);

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
            Write($"{inArray[i, j],5} "); 
        }
        WriteLine();
    }
}

double[] AverageOfColumns(int[,] inArray)
{
    double[] Averege = new double[inArray.GetLength(1)];
    for(int j = 0; j<inArray.GetLength(1); j++)
    {
        double currentSum = 0; 
        for(int i = 0; i < inArray.GetLength(0); i++){
            currentSum = currentSum + inArray[i,j];
        }
        Averege[j] = Math.Round(currentSum / inArray.GetLength(0),2);
        Write($"{Averege[j],5} ");
    }
    return Averege;
}