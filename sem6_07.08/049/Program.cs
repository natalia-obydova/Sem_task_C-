﻿// Показать двумерный массив размером m×n заполненный вещественными случайными числами

int N=5;
int M=4;
double [,] a; //описываем массив
a=new double [N,M]; //создаем массив. можно сделать 2 действия одной строкой int[,] a=new int[N,M]
//инициализация случайными числами
Random random = new Random(); //создали объект типа Random

for (int i=0; i<a.GetLength(0); i++)
{
    for (int j=0; j<a.GetLength(1); j++) 
    {
        a [i, j] = random.NextDouble()*40+3; //по умолчанию диапазон выводимых числе от 0 до 1. 
        //Чтобы расширить диапазон применяется умножение. Прибавление смещает диапазон, в примере от 3 до 43.
        //если применить вычитание (пример *10-3), диапазон будет от -3 до -7
    }
}

//Вывод массива на экран
for (int i=0; i<a.GetLength(0); i++)
{
    for (int j=0; j<a.GetLength(1); j++) System.Console.Write($"{a[i,j]:F2} "); //F2 - цифра 2 обозначает кол-во знаков после запятой
    System.Console.WriteLine();
}