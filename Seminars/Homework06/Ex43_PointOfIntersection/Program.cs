// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double[] PointOfIntersection(int b1, int k1, int b2, int k2)
{
    double x = ((double)b2 - (double)b1) / ( (double)k1 - (double)k2);
    double y = ((double)k1 * x) + (double)b1;
    return new double[] { x, y };
}

void PrintArray<T>(T[] array)
{
  Console.WriteLine($"[{string.Join("; ", array)}]");
}

PrintArray(PointOfIntersection(2, 5, 4, 9));
