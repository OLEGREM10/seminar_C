


int SumDigits(int x)
{
    int sum = 0;
    while (x > 0)
    {
        sum = sum + x % 10;
        x = x / 10;
    }
    return sum;
}
Console.WriteLine(SumDigits(35));



int Proizv(int a, int b)
{
    int res = 1;
    for (int i = 1; i <= b; i++) res = res * a;
    return res;

}

int ProizvRek(int a, int b)
{
    if (b == 0) return 1;
    else return a * ProizvRek(a, b - 1);

}

Console.WriteLine(Proizv(2, 8));
Console.WriteLine(ProizvRek(2, 8));




int SUM(int N)
{
    int i = N;
    if (i == 0) return 0;
    else return i + SUM(i - 1);
}

Console.WriteLine(SUM(5));




int SUM(int n)
{
    // int i=N;
    if (n == 0) return 0;
    else return n + SUM(n - 1);
}




int SUM2(int N)
{
    int summ = 0;
    for (int i = N; i > 0; i--)
        summ += i;
    return summ;
}


Console.WriteLine(SUM(5));
Console.WriteLine(SUM2(5));



int SUM(int N)
{
    int i = N;
    if (i == 0) return 0;
    else return i + SUM(i - 1);
}

Console.WriteLine(SUM(5));