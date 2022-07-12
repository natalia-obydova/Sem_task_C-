// Написать программу вычисления значения функции y = sin(a). (Класс Math)

double x, y;
x = Math.PI; //константа пи
y = Math.Sin(x);
System.Console.WriteLine($"sin({x})={y}");

/*
//тип возвращаемого значения Имя_функции (аргументы функции)
double Sin(double x)//double - тип возвращаемого значения, Sin - название функции, в скобках аргумент.
{
    return Math.Sin(x);
}
void Pause()
{
    System.Console.WriteLine("Press any key");
}

double y=Sin(3.14);
System.Console.WriteLine(y);
*/