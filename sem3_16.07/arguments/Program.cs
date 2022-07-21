//Пример. Поменять местами значения переменных.
/* 
int a, b;
a=1;
b=2;
System.Console.WriteLine($"{a} {b}");
*/
/* без объявления третьей переменной.
a=a+b;
b=a-b;
a=a-b;
System.Console.WriteLine($"{a} {b}");
*/
/* объявление 3ей переменной
int t=a;
a=b;
b=t;
System.Console.WriteLine($"{a} {b}");
*/

void Swap (ref int a, ref int b) //ref модификатор аргумента, если в подпрограмме нужно изменить значение переменной
{
    int t=a;
    a=b;
    b=t;
}
void Calc(int a, int b, out int sum, out int sub)//out - модификатор который позволяет не задавать начальные значения
{
    sum=a+b;
    sub=a-b;
}
//int n=Convert.ToInt32(Console.ReadLine());
//int n=int.Parse(Console.ReadLine());
//Защита от дурака
string s;
int n;
bool f;
do
{
s=Console.ReadLine();
f=int.TryParse(s, out n);
if (f==false) System.Console.WriteLine("Wrong input");
}
while (f==false);
System.Console.WriteLine(n);
/*
int a, b, sum, sub;
a=1;
b=2;
Calc(a,b, out sum, out sub);
*/
/*
System.Console.WriteLine($"{a} {b}");
Swap (ref a,ref b);
System.Console.WriteLine($"{a} {b}");
*/