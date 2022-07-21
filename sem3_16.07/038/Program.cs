// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int N=123;
int[] arr=new int [N];
int s=0;
Random random=new Random(); 
for (int i=0; i<arr.Length; i++)
{
    arr[i]=random.Next(0,1000);
    System.Console.WriteLine(arr[i]);
    if (arr[i]>=10 && arr[i]<=99) s++;

}
System.Console.WriteLine(s);
