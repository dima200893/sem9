Console.Write("Введите M=");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите N=");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int m, int n)
{
    int summ = 0;
    int max = n;
    int min = m;
    if (max < min)
    {
        max = m;
        min = n;
    }
    if (min == max)
    {
        return summ=summ+min;
    }
    else
    {
        summ = NaturalNumber(max - 1, min) + max;
        return summ;
    }

}
