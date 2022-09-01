// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

string ThirdDigit(int val)
{
  string answ = "Thete is no third digit";
  if (val.ToString().Length < 3 ) return answ;
  else return val.ToString().Substring(2, 1);
}

Console.WriteLine(ThirdDigit(645));
Console.WriteLine(ThirdDigit(78));
Console.WriteLine(ThirdDigit(32679));
Console.WriteLine(ThirdDigit(780));
