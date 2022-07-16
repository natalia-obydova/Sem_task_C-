// Вывести на экран кубы чисел от 1 до N

System.Console.Write("Введите целое число: ");
string? s=Console.ReadLine();
int n=Convert.ToInt32(s);

for(int i=1; i<=n; i++)
System.Console.WriteLine(Math.Pow(i,3));
