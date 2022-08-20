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
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
{5, 2, 6, 7},
};
Print(arr);


int Sum = 0, Sum1 = 0, Sum2 = 0, Row = 0;
for (int i = 0; i < arr.GetLength(0); i++) //Проходим по циклу строк
{
    Sum2 = 0;
    for (int j = 0; j < arr.GetLength(1); j++) //Проходим по циклу столбцов
    {
        Sum2 = Sum2 + arr[i, j]; //Сумма всех членов 1ой строки.
    }
    if (Sum2 < Sum1)
    {
        Sum = Sum2; Row = i;
    }
    Sum1 = Sum2;
}
System.Console.WriteLine();
Console.WriteLine("{0} строка", Row);

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
