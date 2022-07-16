// Дано число обозначающее день недели. Выяснить является номер дня недели выходным.

System.Console.Write("Введите номер дня недели: ");
string? s=Console.ReadLine();
int d=Convert.ToInt32(s);
if (d>7 || d<1)
    System.Console.WriteLine("Неверно введен номер дня");
else 
{    
    if (d==7 || d==6)
        System.Console.WriteLine("Выходной день");
    else
        System.Console.WriteLine("Будний день((");
}