// Задача 50. Напишите программу, которая на вход принимает позиции элемента 
// в двумерном массиве, и возвращает значение этого элемента или же указание, 
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет


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

int[,] table3_4 = CreateTable(3, 4);
int[,] fillesTable3_4 = FillTableRandomVal(table3_4, -9, 9);
PrintTable(fillesTable3_4);


string GetArrayValue(int[,] table, int row, int column)
{
  if (
    row < 0 || column < 0 || 
    row > table.GetLength(0) ||
    column > table.GetLength(1)
    ) return "there is no data";
  else return table[row-1, column-1].ToString();

}

System.Console.WriteLine(GetArrayValue(fillesTable3_4, -1, 0));
System.Console.WriteLine(GetArrayValue(fillesTable3_4, 1, 5));
System.Console.WriteLine(GetArrayValue(fillesTable3_4, 1, 1));
System.Console.WriteLine(GetArrayValue(fillesTable3_4, 1, 4));
System.Console.WriteLine(GetArrayValue(fillesTable3_4, 2, 2));
System.Console.WriteLine(GetArrayValue(fillesTable3_4, 3, 1));
System.Console.WriteLine(GetArrayValue(fillesTable3_4, 3, 4));
