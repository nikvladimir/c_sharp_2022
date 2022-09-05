// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223 -> 4

string text1 = "0, 7, 8, -2, -2";
string text2 = "1, -7, 567, 89, 223";

int CountPosNumbers(string array)
{
  var posNums = array.Split(", ")
                  .Select(int.Parse)
                  .Where(e => e > 0)
                  .ToArray();
  return posNums.Length;
}

System.Console.WriteLine(CountPosNumbers(text1));
System.Console.WriteLine(CountPosNumbers(text2));
