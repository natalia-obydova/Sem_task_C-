// Возведите число А в натуральную степень B используя цикл

System.Console.Write("Введите целое число: ");
string? s=Console.ReadLine();
int A=Convert.ToInt32(s);

System.Console.Write("Введите степень числа: ");
s=Console.ReadLine();
int B=Convert.ToInt32(s);
int D=1;
for (int i=1; i<=B; i++)
D=D*A;
System.Console.WriteLine(D);