/*Даны две квадратных таблицы чисел. Требуется построить третью,каждый элемент которой равен сумме элементов
стоящих на том же месте в 1-й и 2-й таблицах. 
Входные данные
Во входном файле записано сначала число N, затем записана первая таблица,а после нее - вторая.
Элементы таблиц - числа от 0 до 100. 100>=N>=1.
*/

System.Console.WriteLine("Введите размер квадратного массива: ");
int N = Convert.ToInt32(System.Console.ReadLine());
int[,] a1 = new int[N, N];
int[,] a2 = new int[N, N];
int[,] a3 = new int[N, N];

Random random = new Random(); //создали объект типа Random
//1 массив
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        a1[i, j] = random.Next(1, 11);
        System.Console.Write($"{a1[i, j]} ");

    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
//2 массив
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        a2[i, j] = random.Next(1, 11);
        System.Console.Write($"{a2[i, j]} ");

    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

//3 массив

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        a3[i, j] = a1 [i, j] + a2 [i, j]; 
        System.Console.Write($"{a3[i, j]} ");
       
    }
    System.Console.WriteLine();
}


