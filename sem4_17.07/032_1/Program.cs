// Задать массив из 8 элементов и вывести их на экран

int[] t; //объявление массива
//инициализация
Init (out t, 8, 0, 10);
//решение
//вывод результатов на экран
Print (t, "t");

void Init(out int[] t, int Lenght, int min, int max)
{
    t=new int[Lenght];
    Random random= new Random();
    for(int i=0; i<t.Length; i++)
        t[i]=random.Next(min, max);
}

void Print (int [] t, string variableName)
{
    for(int i=0; i<t.Length;i++)
    System.Console.Write($"{variableName} [{i}]={t[i]} "); 
}