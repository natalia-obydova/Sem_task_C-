/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива. Например задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int[,] arr = new int[,]
{ 
{1, 4, 7, 2},
{5, 9, 2, 3},
{8, 4, 2, 4},
};

Print (arr);
System.Console.WriteLine();
Print(Sort(arr));


int [,] Sort(int[,] arr)
{
    for(int i=0;i<arr.GetLength(0); i++)
    {
        for(int j=0; j<arr.GetLength(1)-1; j++)
        { 
            int max=0; 
            int iMax=0; 
            for(int k=j; k<arr.GetLength(1); k++) 
            {
                if (arr[i,k]>max)   
                {
                    max=arr[i,k]; 
                    iMax=k;     
                }        
            }    
            if (iMax!=j)
            {
                int P=arr[i,j];
                arr[i,j]=arr[i,iMax]; 
                arr[i,iMax]=P; 
            }
        } 
    }
    return arr;
}


void Print (int [,] arr)
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