// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowsDigits(ref int[,] table)
{
  for (int rows = 0; rows < table.GetLength(0); rows++ )
  {
    List<int> rowInList = new List<int>(); 
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      rowInList.Add(table[rows, columns]);
    }
    var orderedList =  rowInList.OrderByDescending(i => i);
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      table[rows, columns] = orderedList.ElementAt(columns);
    }
  }
}


int[,] table3_4 = CreateTable(3, 4);
FillTableRandomVal(ref table3_4, fromValue: 0, toValue: 9);
PrintTable(table3_4);
System.Console.WriteLine("Sortered matrix:");

SortRowsDigits(ref table3_4);
PrintTable(table3_4);