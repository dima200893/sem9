Console.Write("Введите M=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int m, int n)
{
    int max = n;
    int min = m;
    if (max < min)
    {
        max = m;
        min = n;
    }
    if (min == max)
    {
        return min;
    }
    else
    {
        Console.Write(NaturalNumber(max - 1, min) + ",");
        return max;
    }
}
