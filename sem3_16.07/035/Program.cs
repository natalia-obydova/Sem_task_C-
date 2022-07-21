// Написать программу замены элементов массива на противоположные


int N=8;
int[] arr=new int [N];
Random random=new Random(); 
for (int i=0; i<arr.Length; i++)
{
    arr[i]=random.Next(0,10);
    System.Console.Write($"{arr[i]}  ");
}
System.Console.WriteLine();
int t;
for (int i=0; i<arr.Length/2; i++)
{
    t=arr[i];
    arr[i]=arr[N-i-1];
    arr[N-i-1]=t;
}
for (int i=0; i<arr.Length; i++)
System.Console.Write($"{arr[i]}  ");
