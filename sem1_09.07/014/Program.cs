// С клавиатуры вводятся два числа a и b. 
//Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b.

System.Console.WriteLine("Введите число a: ");
string? a = Console.ReadLine();
int a1 = Convert.ToInt32(a);
System.Console.WriteLine("Введите число b: ");
string? b = Console.ReadLine();
int b1 = Convert.ToInt32(b);

if (a1%b1==0)
{
    System.Console.WriteLine("кратно");
}
else
{
    System.Console.WriteLine("остаток a/b=" + a1%b1);
}