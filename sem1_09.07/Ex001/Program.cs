//С клавиатуры вводится целое число. Вывести квадрат числа 
int a=50;
int b;
string? s=Console.ReadLine();//ввод данных
a=Convert.ToInt32(s);
b=a*a;//обработка данных 
System.Console.WriteLine($"{a}^2={b}");//строка интерполяции. вывод результата

/*
string? s;
s=Console.ReadLine();
System.Console.WriteLine(s);
*/