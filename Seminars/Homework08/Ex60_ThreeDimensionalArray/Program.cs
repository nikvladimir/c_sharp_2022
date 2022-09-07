// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


List<int> ListOfRandomNumbers(int length, int fromValue, int toValue)
{
  List<int> randomList = new List<int>();
  for (int ind = 0; ind < length; ind++ )
  {
    int newNumb = new Random().Next(fromValue, toValue);
    bool isInList = randomList.IndexOf(newNumb) != -1;
    if (!isInList) randomList.Add(newNumb);
  }
  Console.WriteLine($"[{string.Join(", ", randomList)}]");
  return randomList;
}

List<int> Random8Numbs = ListOfRandomNumbers(length: 8, fromValue: 10, toValue: 100);


int[,,] ThreeDimensionalArray(List<int> numbersForArray)
{
  int[,,] table = new int[2, 2, 2];
  for (int i = 0; i < table.GetLength(0); i++)
  {
    int numbIndex = 0;
    for (int j = 0; j < table.GetLength(1); j++)
    {
      for (int k = 0; k < table.GetLength(2); k++)
        {
          table[i, j, k] = numbersForArray.ElementAt(numbIndex);
          numbIndex++;
          // Console.WriteLine($"{table[i, j, k]} index is: ({i},{j},{k})");
        }
    }
  }
  return table;
}

int[,,] newArray = ThreeDimensionalArray(Random8Numbs);

void PrintThreeDimensionalArray(int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
        {
          Console.WriteLine($"{array[i, j, k]} index is: ({i},{j},{k})");
        }
    }
  }
}

PrintThreeDimensionalArray(newArray);
