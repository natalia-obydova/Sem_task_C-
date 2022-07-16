// Подсчитать сумму цифр в числе

System.Console.Write("Введите целое число: ");
string? s=Console.ReadLine();
int A=Convert.ToInt32(s);
int sum=0;
while (A>0)
{
    sum=sum+A%10;
    A=A/10;
}
System.Console.WriteLine(sum);