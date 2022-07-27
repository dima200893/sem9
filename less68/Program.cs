Console.Write("Введите N=");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите M=");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkermam(n, m));

int Akkermam(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkermam(n - 1, 1);
    else
      return Akkermam(n - 1, Akkermam(n, m - 1));
}

