// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


Console.WriteLine("Please enter the number of rows in the array : ");
    int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter the number of column in the array : ");
    int col = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please enter range : ");
    int range = Convert.ToInt32(Console.ReadLine());

int[,] firstArray = new int[rows, col];
CreateArray(firstArray);
Console.WriteLine("First array: ");
WriteArray(firstArray);

int[,] secondArray = new int[rows, col];
CreateArray(secondArray);
Console.WriteLine("Second array: ");
WriteArray(secondArray);

int[,] resultMatrix = new int[rows, col];

MultiplyMatrix(firstArray, secondArray, resultMatrix);
Console.WriteLine("Result of matrix multiplication :");
WriteArray(resultMatrix);

void MultiplyMatrix(int[,] firstArray, int[,] secondArray, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstArray.GetLength(1); k++)
      {
        sum += firstArray[i,k] * secondArray[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
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