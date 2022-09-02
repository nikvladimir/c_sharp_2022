int GetTryParse(string v)
{
    int a = -20;
    while (true)
    {
        Console.Write(v);
        string s = Console.ReadLine();
        bool f = int.TryParse(s, out a);
        if (f && a >= -10 && a <= 10) break;
    }
    return a;
}


int a = GetTryParse("Give me the nuber from -10 to 10: ");