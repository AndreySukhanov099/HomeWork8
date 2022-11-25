//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Введите колличество строк");
int LineVolue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int ColumnsVolue = Convert.ToInt32(Console.ReadLine());
int [,] array = GetArrayRandom(LineVolue, ColumnsVolue);

PrintArray(array);
MinSumLine(array);



int [,] GetArrayRandom(int LineVolue,int ColumnsVolue, int minValue = 0, int maxValue = 10)
{
    int[,] array = new int[LineVolue, ColumnsVolue];
    var rnd = new Random();
    for (int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            array [i, j] = rnd.Next(minValue, maxValue );
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
for (int i =0; i < array.GetLength(0); i++)
    {
        for(int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
void MinSumLine(int[,] array)
{
    int minLine = 0;
    int minSumLine = 0;
    int sumLine = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        minLine += array[0, i];
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) sumLine += array[i, j];
        if (sumLine < minLine)
        {
            minLine = sumLine;
            minSumLine = i;
        }
        sumLine = 0;
    }
    Console.Write($"{minSumLine + 1} строка");
}