// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


double DistanceBetweenPoints(int[] a, int[] b)
{
  double answ = Math.Sqrt(
    Math.Pow(a[0] - b[0], 2) + 
    Math.Pow(a[1] - b[1], 2) + 
    Math.Pow(a[2] - b[2], 2)
    );
  return Math.Round(answ, 2);
}


int[] a = {3, 6, 8};
int[] b = {2, 1, -7};
int[] c = {7, -5, 0};
int[] d = {1, -1, 9};


Console.WriteLine(DistanceBetweenPoints(a, b));
Console.WriteLine(DistanceBetweenPoints(c, d));
