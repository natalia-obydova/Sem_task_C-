// Найти расстояние между точками в пространстве 2D

int x1,x2, y1, y2;
System.Console.Write("Введите x1: ");
string? s=Console.ReadLine();
x1=Convert.ToInt32(s);

System.Console.Write("Введите y1: ");
s=Console.ReadLine();
y1=Convert.ToInt32(s);

System.Console.Write("Введите x2: ");
s=Console.ReadLine();
x2=Convert.ToInt32(s);

System.Console.Write("Введите y2: ");
s=Console.ReadLine();
y2=Convert.ToInt32(s);

int x=x2-x1;
int y=y2-y1;
double d;
d=Math.Sqrt(Math.Pow(x,2)+Math.Pow(y,2));
System.Console.WriteLine(d);





