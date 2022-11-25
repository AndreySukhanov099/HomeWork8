/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Введите колличество строк");
int LineVolue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите колличество столбцов");
int ColumnsVolue = Convert.ToInt32(Console.ReadLine());
int [,] array = GetArrayRandom(LineVolue, ColumnsVolue);

PrintArray(array);
SortDescrease(array);
Console.WriteLine();
PrintArray(array);



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
void SortDescrease(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}