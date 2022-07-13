// С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

System.Console.Write("Введите целое число от 10 до 99: ");
string? a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (b>=10 && b<=99)
{
    int c = b%10;
    int d = b/10;
    if (c>d) System.Console.WriteLine(c);
    else System.Console.WriteLine(d);
}
else 
{
    System.Console.WriteLine("ALARM");
}
