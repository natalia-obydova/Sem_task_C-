// Найти сумму чисел от 1 до А

System.Console.Write("Введите целое число: ");
string? s=Console.ReadLine();
int A=Convert.ToInt32(s);

int sum=0;

for(int i=1; i<=A; i++)

sum=i+sum;
System.Console.WriteLine(sum);
