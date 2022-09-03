// Задача 25
// Напишите цикл, который на вход принимает два числа
// А и В и возводит число А в натуральную степень В

// 3, 5 -> 243
// 2, 4 -> 16


int DehreeOfNumb(int val, int degree)
{
  int answ = val;
  for (int i = 1; i < degree; i++)
  {
    answ = answ * val;
  }
    return answ;
}


Console.WriteLine(DehreeOfNumb(3, 5));
Console.WriteLine(DehreeOfNumb(2, 4));
