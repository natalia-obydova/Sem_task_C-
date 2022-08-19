//Написать программу вычисления функции Аккермана
int rec(int n, int m)
{
    if (n == 0) return m + 1;
    if (n > 0 && m == 0) return rec (n-1, 1);
    else return rec (n-1, rec(n, m-1));
}

System.Console.WriteLine(rec(2,3));
