/*
Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей 
суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/


int[,] arr = new int[,]
{
{5, 9, 2, 3},
{1, 4, 7, 2},
{8, 4, 2, 4},
{5, 2, 6, 7},
};
Print(arr);


int SumMin = 0, Sum = 0, Row = 0;
for (int i = 0; i < arr.GetLength(0); i++) //Проходим по циклу строк
{
    Sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++) //Проходим по циклу столбцов
    {
        Sum = Sum + arr[i, j]; //Сумма всех членов 1ой строки.
    }
    if (Sum < SumMin || i == 0) 
    {
        SumMin = Sum; 
        Row = i;
    }
}
System.Console.WriteLine();
Console.WriteLine("{0} строка", Row+1);

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
