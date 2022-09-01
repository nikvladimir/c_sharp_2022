// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int val)
{
  return val / 10 % 10;
}

Console.WriteLine(SecondDigit(456));
Console.WriteLine(SecondDigit(782));
Console.WriteLine(SecondDigit(918));
