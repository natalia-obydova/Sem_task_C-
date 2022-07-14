// С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

System.Console.Write("Введите целое число: ");
string? a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (b>=100)
{
    System.Console.WriteLine(b/100%10);
}
else
{
    System.Console.WriteLine("Число меньше 100.");
}