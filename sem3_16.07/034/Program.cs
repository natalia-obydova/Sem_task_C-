// Задать массив из 12 элементов, заполненных числами из [-9, 9]. 
//Найти сумму положительных/отрицательных элементов массива

//инициализация массива
int N=12;
int[] a=new int [N];
Random random=new Random(); //псевдослучайные числа
for (int i=0; i<a.Length; i++)
    a[i]=random.Next(-9,10);

//вывод массива (до обработки)    
for (int i=0; i<a.Length; i++)
    System.Console.Write($"{a[i],4}"); //,4 - для каждого символа будет выделено 4 знакоместа

//решение задачи
int sumPositive=0;
for (int i=0; i<a.Length; i++)
    if (a[i]>0)
        sumPositive=sumPositive+a[i];

int sumNegative=0;
for (int i=0; i<a.Length; i++)
    if (a[i]<0)
        sumNegative+=a[i];
//вывод результата
System.Console.WriteLine(sumNegative);
System.Console.WriteLine(sumPositive);

