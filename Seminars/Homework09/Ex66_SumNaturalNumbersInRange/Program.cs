// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbersInRange(int start, int finish)
{
    List<int> rowInList = new List<int>();
    int sum = 0;
    while(start <= finish)
    {
        sum += start;
        start++;
    }
    return sum;
}

System.Console.WriteLine(SumNaturalNumbersInRange(1, 15));
System.Console.WriteLine(SumNaturalNumbersInRange(4, 8));
