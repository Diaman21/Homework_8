// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку
//  с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
//  наименьшей суммой элементов: 1 строка

Console.Write("Ведите кол-во строк: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Ведите кол-во колонн: ");
int n = int.Parse(Console.ReadLine() ?? "0");
int[,] array = new int[m, n];
FillArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"{RowWithLowestSumm(array)} строка");
int RowWithLowestSumm(int[,] matrixArray)
{
    int min = 0;
    int sum = int.MaxValue;
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        int rowSumm = 0;
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            rowSumm += matrixArray[i, j];
        }
        if (rowSumm < sum)
        {
            sum = rowSumm;
            min = i+1;
        }
    }
    return min;
}
void FillArray(int[,] matrixArray)
{
    Random rnd = new Random();
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            matrixArray[i, j] = rnd.Next(1, 10);
        }
    }
}
void PrintArray(int[,] matrixArray)
{
    for (int i = 0; i < matrixArray.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < matrixArray.GetLength(1); j++)
        {
            Console.Write(matrixArray[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}