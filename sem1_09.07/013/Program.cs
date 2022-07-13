// Удалить вторую цифру целого числа введенного с клавиатуры.

System.Console.Write("Введите целое число: ");
string? a = Console.ReadLine();
int b = Convert.ToInt32(a);
int c = b%10;
int d = b/100;
System.Console.WriteLine(d*10+c);