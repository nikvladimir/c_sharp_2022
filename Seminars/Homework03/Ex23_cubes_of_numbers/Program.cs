// Задача 23
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125




double[] CubesOfNumbers(int num)
{
  double[] array = new double[] { };
  for (int i = 1; i <= num; i++) array = array.Append(Math.Pow(i, 3)).ToArray();
  return array;
}

Console.WriteLine(string.Join(", ", CubesOfNumbers(3)));
Console.WriteLine(string.Join(", ", CubesOfNumbers(5)));
