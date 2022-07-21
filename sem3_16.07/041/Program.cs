// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int N=8;
int[] arr=new int [N];
Random random=new Random();
for (int i=0; i<arr.Length; i++)
{
    arr[i]=random.Next(1,30);
    System.Console.Write($"{arr[i],4}");
}

int min=arr[0];
int max=arr[0];
for (int i=0; i<arr.Length; i++)
{
    if (arr[i]<min) min=arr[i];
    if (arr[i]>max) max=arr[i];
}
System.Console.WriteLine();
System.Console.Write($"{max} - {min} = {max-min}");

