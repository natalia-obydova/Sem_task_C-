// С клавиатуры вводятся три числа. Найти максимальное из трех чисел


int a,b,c;
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
s=Console.ReadLine();
b=Convert.ToInt32(s);
s=Console.ReadLine();
c=Convert.ToInt32(s);

int max=a;

if (b>max) max=b;
if (c>max) max=c;
System.Console.WriteLine(max);

/*
int a=15;
int b=23;
int c=40;
int max= Max(a,b,c);
int Max (int arg1, int arg2, int arg3);
{
    int result = arg1;
    if (arg2> result) result=arg2;
    if (arg3> result) result=arg3;
    return result;
}
*/