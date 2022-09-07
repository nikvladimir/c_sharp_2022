// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер 
// строки с наименьшей суммой элементов: 1 строка


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

int RowMinSumDigits(ref int[,] table)
{
  List<int> sumIchRow = new List<int>();
  for (int rows = 0; rows < table.GetLength(0); rows++ )
  {
    int sumRow = 0; 
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      sumRow += table[rows, columns];
    }
    sumIchRow.Add(sumRow);
  }

  int minSum = sumIchRow.ElementAt(0);
  int minIndex = 0;

  for (int i = 0; i < sumIchRow.Count; i++ )
  {
    if (sumIchRow.ElementAt(i) < minSum)
    {
      minSum = sumIchRow.ElementAt(i);
      minIndex = i + 1;
    }
  }

  return minIndex;
}


int[,] table3_4 = CreateTable(3, 4);
FillTableRandomVal(ref table3_4, fromValue: 0, toValue: 2);
PrintTable(table3_4);
System.Console.Write("Row with min sum digits is: ");
System.Console.WriteLine(RowMinSumDigits(ref table3_4));
