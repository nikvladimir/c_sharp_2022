// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateArray(int length)
{
  int[] array = new int[] { };
  for (int i = 1; i <= length; i++)
  {
    array = array.Append(new Random().Next(100, 1000)).ToArray();
  }
  return array;
}


int CountEvenInArray (int[] array)
{
  int numOfEven = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] % 2 == 0) numOfEven++;
  }
  return numOfEven;
}

System.Console.WriteLine(CountEvenInArray(CreateArray(4)));
System.Console.WriteLine(CountEvenInArray(CreateArray(5)));
System.Console.WriteLine(CountEvenInArray(new int[] { 345, 897, 568, 234 }));
