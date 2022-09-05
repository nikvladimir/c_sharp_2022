// Задача 36: Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length)
{
  int[] array = new int[] { };
  for (int i = 1; i <= length; i++)
  {
    array = array.Append(new Random().Next(100, 1000)).ToArray();
  }
  return array;
}

int SumNotEvenPositionsElements (int[] array)
{
  int numOfEven = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (i % 2 != 0) numOfEven += array[i];
  }
  return numOfEven;
}

System.Console.WriteLine(SumNotEvenPositionsElements(CreateArray(4)));
System.Console.WriteLine(SumNotEvenPositionsElements(CreateArray(5)));
System.Console.WriteLine(SumNotEvenPositionsElements(new int[] {3, 7, 23, 12}));
System.Console.WriteLine(SumNotEvenPositionsElements(new int[] {-4, -6, 89, 6}));
