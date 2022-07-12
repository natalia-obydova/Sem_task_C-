// Вывести на экран числа от -N до N

string a;
Console.Write("Введите число: ");
a = Console.ReadLine();
int n = Convert.ToInt32(a);
int nn=-n;
while(nn<=n)
{
    Console.Write(nn + " ");
    nn++;
}
