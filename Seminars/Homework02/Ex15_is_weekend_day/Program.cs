// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

string IsWeekendDay(int val)
{
  string yes = "yes";
  string no = "no";
  string exception = "there is no a week day";

  if ( val < 1 | val > 7 ) return exception;

  if (val == 6 | val == 7 ) return yes;
  else return no;
}

Console.WriteLine(IsWeekendDay(0));
Console.WriteLine(IsWeekendDay(1));
Console.WriteLine(IsWeekendDay(5));
Console.WriteLine(IsWeekendDay(6));
Console.WriteLine(IsWeekendDay(7));
Console.WriteLine(IsWeekendDay(8));
