// Программа проверяет пятизначное число на палиндром.

System.Console.Write("Введите пятизначное число: ");
string? s=Console.ReadLine();
int a=Convert.ToInt32(s);
if (a<10000 || a>99999)
{
    System.Console.WriteLine("Введено неверное число.");
    return;
}
int n1=a/10000;
int n2=a/1000%10;
int n4=a/10%10;
int n5=a%10;
if (n1==n5 && n2==n4)
    System.Console.WriteLine("Введенное число является палиндромом.");
else
    System.Console.WriteLine("Введенное число не является палиндромом.");