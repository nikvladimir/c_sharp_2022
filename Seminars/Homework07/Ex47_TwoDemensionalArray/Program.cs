// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int[,] CreateTable(int row, int columns)
{
  return new int[row, columns];
}


void FillTableRandomVal(ref int[,] table, int fromValue, int toValue)
{
  for (int rows = 0; rows < table.GetLength(0); rows++ )
  {
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      table[rows, columns] = new Random().Next(fromValue, toValue);
    }
  }
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

int[,] table3_4 = CreateTable(3, 4);
FillTableRandomVal(ref table3_4, -9, 9);

PrintTable(table3_4);
PrintTable(table3_4);
