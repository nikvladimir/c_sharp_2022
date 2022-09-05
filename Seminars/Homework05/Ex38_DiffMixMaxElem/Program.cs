// Задача 38: Задайте массив вещественных чисел. Найдите разницу
// между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


int[] CreateArray(int length)
{
  int[] array = new int[length];
  for (int i = 1; i <= length; i++)
  {
    array = array.Append(new Random().Next(100, 1000)).ToArray();
  }
  return array;
}

int DiffMixMaxElem (int[] array)
{
  int min = array[0], max = array[0];
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
  }
  return max - min;
}

System.Console.WriteLine(DiffMixMaxElem(CreateArray(4)));
System.Console.WriteLine(DiffMixMaxElem(CreateArray(5)));
System.Console.WriteLine(DiffMixMaxElem(new int[] {3, 7, 22, 2, 78}));
