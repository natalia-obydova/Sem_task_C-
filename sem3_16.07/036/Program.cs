// Определить, присутствует ли в заданном массиве, некоторое число

//инициализация массива
int N=12;
int[] a=new int [N];
Random random=new Random(); //псевдослучайные числа
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);

//решение задачи
int f=400;
a[3]=f;
//вывод массива (до обработки)    
for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}"); //,4 - для каждого символа будет выделено 4 знакоместа

//линейный поиск
int j=0;
while(j<a.Length && a[j]!=f) j++;
if (j==a.Length) System.Console.WriteLine("Not found");
else System.Console.WriteLine($"\nElement {f} finded at {j}");//"\n" - new line. \ можно добавить команду внутри строки. n - новая строка.

//вывод результата


