//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

Console.WriteLine("Введите размеры матриц и диапазон случайных значений:");
int m = InputNumbers("Введите число строк 1-й матрицы: ");
int n = InputNumbers("Введите число столбцов 1-й матрицы (и строк 2-й): ");
int p = InputNumbers("Введите число столбцов 2-й матрицы: ");
int range = InputNumbers("Введите диапазон случайных чисел: от 1 до ");

int[,] OneMatrix = new int[m, n];
CreateArray(OneMatrix);
Console.WriteLine($"Первая матрица:");
WriteArray(OneMatrix);

int[,] TwoMatrix = new int[n, p];
CreateArray(TwoMatrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(TwoMatrix);

int[,] rproductOfMatrices = new int[m,p];

MultiplyMatrix(OneMatrix, TwoMatrix, rproductOfMatrices);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(rproductOfMatrices);

void MultiplyMatrix(int[,] OneMatrix, int[,] TwoMatrix, int[,] rproductOfMatrices)
{
  for (int i = 0; i < rproductOfMatrices.GetLength(0); i++)
  {
    for (int j = 0; j < rproductOfMatrices.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < OneMatrix.GetLength(1); k++)
      {
        sum += OneMatrix[i,k] * TwoMatrix[k,j];
      }
      rproductOfMatrices[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}


