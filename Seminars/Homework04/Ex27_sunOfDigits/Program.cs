// Задача 27
// Напишите программу, которая принимает на вход число
// и выдаёт сумму цифр в этом числе.
// 452 -> 11
// 82  -> 10
// 9012-> 12


int SumOfDigits(int val)
{
    int answer = 0;
    while ( val > 0 ) 
    {
      answer = answer + val % 10;
      val = val / 10;
    }
    return answer;
}

Console.WriteLine(SumOfDigits(452));
Console.WriteLine(SumOfDigits(82));
Console.WriteLine(SumOfDigits(9012));
