// Задача 29
// Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


double[] CreateArray(int length)
{
  double[] array = new double[] { };
  for (int i = 1; i <= length; i++)
  {
    array = array.Append(new Random().Next(0, 10)).ToArray();
  }
  return array;
}


void PrintArray<T>(T[] array)
{
  Console.WriteLine($"[{string.Join(", ", array)}]");
}

PrintArray(CreateArray(8));
PrintArray(CreateArray(3));
