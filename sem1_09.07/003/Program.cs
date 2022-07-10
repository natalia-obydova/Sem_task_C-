// С клавиатуры вводятся два числа a и b. Найти максимальное из них.

int a,b;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
int max=a;

if (a>b) max=a;
if (b>a) max=b;
System.Console.WriteLine(max);
