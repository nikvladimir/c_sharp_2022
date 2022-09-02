string s = "341434234";
char[] c = s.ToCharArray();
Array.Reverse(c);

String reversed = String.Join("", c);
Console.WriteLine($"first is: {s} and second is:{reversed}");
