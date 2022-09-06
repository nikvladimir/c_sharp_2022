// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateTable(int row, int columns)
{
  return new int[row, columns];
}

int[,] FillTableRandomVal(int[,] newTable, int fromValue, int toValue)
{
  for (int rows = 0; rows < newTable.GetLength(0); rows++ )
  {
    for (int columns = 0; columns < newTable.GetLength(1); columns++ )
    {
      newTable[rows, columns] = new Random().Next(fromValue, toValue);
    }
  }
  return newTable;
}

void PrintTable(int[,] table)
{
  for (int rows = 0; rows < table.GetLength(0); rows++ )
  {
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      Console.Write($"{table[rows, columns]} ");
    }
    Console.WriteLine();
  }
}

void PrintArray<T>(T[] array)
{
  Console.WriteLine($"{string.Join(", ", array)}");
}

int[,] table3_4 = CreateTable(3, 4);
int[,] fillesTable3_4 = FillTableRandomVal(table3_4, 0, 9);
PrintTable(fillesTable3_4);

double[] ArithmeticMeanEachColumn(int[,] table)
{
  double[] res = new double[table.GetLength(0)];
  for (int row = 0; row < table.GetLength(0); row++ )
  {
    double rowSum = 0.0;
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      rowSum += table[row, columns];
    }
    res[row] = Math.Round(rowSum / table.GetLength(1), 2);
    System.Console.WriteLine($"rowSum is: {rowSum} table.GetLength is: {table.GetLength(1)} res[{row}] is: {res[row]}");
  }
  return res;
}

PrintArray(ArithmeticMeanEachColumn(fillesTable3_4));
