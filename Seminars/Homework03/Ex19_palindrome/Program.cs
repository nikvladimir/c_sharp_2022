// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да



bool IsReverse(int val)
{
    int inpValue = val;
    int reversed = 0;
    while ( val > 0 ) 
    {
      reversed = reversed * 10 + val % 10;
      val = val / 10;
    }
    return inpValue == reversed;
}

void ConsoleUnswer(bool val)
{
  if (val) Console.WriteLine("yes");
  else  Console.WriteLine("no");
}

ConsoleUnswer(IsReverse(14212));
ConsoleUnswer(IsReverse(12821));
ConsoleUnswer(IsReverse(23432));
