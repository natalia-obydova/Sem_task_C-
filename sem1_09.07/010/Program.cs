// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

System.Console.WriteLine("Введите целое число: ");
string a=System.Console.ReadLine();
int b=Convert.ToInt32(a);
System.Console.WriteLine(b%10);



