// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

void ShowNaturalNumbersInRange(int start, int finish)
{
    List<int> rowInList = new List<int>();
    while(start <= finish)
    {
        rowInList.Add(start);
        start++;
    }
    Console.WriteLine($"[{string.Join(", ", rowInList)}]");
}

ShowNaturalNumbersInRange(1, 5);
ShowNaturalNumbersInRange(4, 8);
