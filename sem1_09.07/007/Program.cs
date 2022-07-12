// Выяснить является ли число чётным.

string a;
Console.Write("Введите число: ");
a = Console.ReadLine();
int n = Convert.ToInt32(a);
if(n%2==0)
{
    System.Console.WriteLine("четное");
}
else
{
    System.Console.WriteLine("нечетное");
}
