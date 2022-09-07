// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Akkerman(int number, int argument)
{
    if (number == 0) return argument + 1;
    else if (argument == 0) return Akkerman(number - 1, 1);
    else return Akkerman(number - 1, Akkerman(number, argument - 1));
}

System.Console.WriteLine((Akkerman(2, 3)).ToString());
