// Дана квадратная матрица. Проверить, является ли она симметричной относительно главной диагонали.


bool sim = true;
int[,] a = new int[3, 3] { { 9, 1, 2 }, { 1, 7, 1 }, { 2, 1, 3 } };

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++) System.Console.Write($"{a[i, j]} "); 
    System.Console.WriteLine();
}

for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        if (a[i, j] != a[j, i])
        {
            sim = false;
            break;
        }
    }
}
if (sim) System.Console.WriteLine("массив симметричен");
else System.Console.WriteLine("массив не симметричен");

