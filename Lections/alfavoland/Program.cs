// git init
// dotnet new gitignore
// dotnet new console    - create project
// dotnet run
// int double string bool
// Lesson_2 https://youtu.be/c5c0HYs5NVM?t=5163

// Объявление переменных

int[] array = { 11, 12, 15 };
int[] array = new int[10];  // массив из 10 эл-ов заполненных нулями
string[,] table = new string[2, 3]; // двумерный массив строки и столбцы
table[1, 2] = "new word";
int[,] table = new int[2, 3];  // двумерная таблица

(int x, int y, int z)[] point3D = new (int, int, int)[100];
point3D[0] = (x: 1, y: 2, z: 1);

void PrintTable(int[,] table)
{
  for (int rows = 0; rows < table.GetLength(0); rows++ )  // for + down
  {
    for (int columns = 0; columns < table.GetLength(1); columns++ )
    {
      Console.Write($"{table[rows, columns]}");
    }
    Console.WriteLine();
  }
}

int n = array.Length;
int a = 1;
a.ToString();
a.Split(" ").ToArray();

Console.WriteLine("Enter your name:");  // cw + Tab, next print will be from new line
string username = Console.ReadLine()!;   // считывает данные с консоли, ! означает, что мы гарантируем string
Console.Write($"Hello, {username}");    // печать без перехода на новую строку
Console.Write(String.Format("Hello {0} and {1}!", username, a));    // печать f стринги


double number = Convert.ToDouble(Console.ReadLine());   // int number .ToInt32(numb.ToString())
double numbe2 = double.Parse(Console.ReadLine()!);   // or int.Parse, ! означает, что мы гарантируем double

username.ToLower();                     // для проверки в нижнем регистре

int x = new Random().Next(0, 10);       // [0, 10)
Random().NextDouble() * 10;             // рандом [0, 1) * 10;


Console.Clear();
Console.SetCursorPosition(10, 4);       // столбец, строка
Environment.CurrentDirectory;

double num1 = 3, num2 = 5;
double sum = num1 + num2;
double max = num1;

string res = String.Empty;            // объявление пустой строки
if (max % 2 == 0) res = res + (max + " ");
if (num1 > num2) max = num1;

if(sum == 5)
{
    Console.WriteLine("five");
}
else
{
    Console.WriteLine("not five five");
};

for (int i = 0; i < 11; i++)
{
}

int count = 10;
while (count-- > 0)
{
  break;
};


// функции
int Max(int a, int b)
{
  int res = a;
  if (a < b) res = b;
  return res;
}
int c = Max(1, 2);

string text = "(1,2) (2,3) (4,5) (6,7)";

var data = text.Replace("(", "")
                .Replace(")", "")
                .Split(" ")
                .Select(item => item.Split(","))
                .Select(e => (x: int.Parse(e[0]), y: (int.Parse(e[1]))))
                .Select(point => (point.x * 10, point.y))
                .ToArray();

for (int i = 0; i < data.Length; i++)
{
    System.Console.WriteLine(data[i]);
    // System.Console.WriteLine(data[i].x * 10);
}

void DebucColor(string s)    // void функция которая ни чего не возвращает
{
  Console.ForegroundColor = ConsoleColor.Red;
  Console.WriteLine(s);
}

void PrintArray<T>(T[] array) // печать массива любого типа
{
  Console.WriteLine($"[{string.Join(", ", array)}]");
}

void FillTableRandomVal(ref int[,] table, int fromValue, int toValue)  // изменяет таблицу на которую будет ссылка
FillTableRandomVal(ref table3_4, -9, 9);                               // применение данного метода

// рекурсия
int Factorial(int n)
{
  if (n == 1) return 1;
  else return n * Factorial(n - 1);
}

int Fibonac(int n)
{
  if(n == 1 || n == 2) return 1;
  else return Fibonac(n - 1) + Fibonac(n - 2);
}
// мат операции    / - целочисленное деление (// in Py)

// hotckey
// alt + up/down    - moving code strings
// alt + left/write - navigation in IDE
// alt + shift + up/down  - copeing corrent string
// cw + Tab         - System.Console.WriteLine();
// for + down + Tab - for (int i = 0; i < length; i++)
// while + down + Tab - цикл while

