// Написать программу вычисления произведения чисел от 1 до N

System.Console.Write("Введите целое число: ");
string? s=Console.ReadLine();
int N=Convert.ToInt32(s);

int p=1;

for(int i=1; i<=N; i++)
    p=i*p;
System.Console.WriteLine(p);