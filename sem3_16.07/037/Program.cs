// Задать массив, заполнить случайными положительными трёхзначными числами. 
//Показать количество нечетных\четных чисел

int N=8;
int[] arr=new int [N];
int j=0;
Random random=new Random(); 
for (int i=0; i<arr.Length; i++)
{
    arr[i]=random.Next(100,1000);
    if (arr[i]%2==0) j++;
    System.Console.WriteLine(arr[i]);
}
System.Console.WriteLine("Нечетные: " +(N-j));
System.Console.Write("Четные: "+j);
