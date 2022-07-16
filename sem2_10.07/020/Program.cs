// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x=0;
int y=0;

if (x==0 || y==0)
    System.Console.WriteLine("Введена координата, попадающая на координатную ось. Определить четверть невозможно.");
else
    {
        if (x>0 && y>0)
            System.Console.WriteLine("Первая четверть");
        if (x<0 && y>0)
            System.Console.WriteLine("Вторая четверть");
        if (x<0 && y<0)
            System.Console.WriteLine("Третья четверть");
        if (x>0 && y<0)
            System.Console.WriteLine("Четвертая четверть");    
    }