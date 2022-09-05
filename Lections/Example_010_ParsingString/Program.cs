using System.Linq;

// void PrintArray<T>(T[] array)
// {
//   Console.WriteLine($"[{string.Join(", ", array)}]");
// }

string text = "(1,2) (2,3) (4,5) (6,7)";

var data = text.Replace("(", "")
                .Replace(")", "")
                .Split(" ")
                .Select(item => item.Split(","))
                .Where(e => e.x % 2 == 0)
                .Select(e => (x: int.Parse(e[0]), y: (int.Parse(e[1]))))
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
    // System.Console.WriteLine(data[i].x * 10);
}