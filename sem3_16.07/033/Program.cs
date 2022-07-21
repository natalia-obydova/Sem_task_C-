// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int N=8;
int[] arr=new int [N];
Random random=new Random(); 
for (int i=0; i<arr.Length; i++)
{
    arr[i]=random.Next(0,2);
    System.Console.Write(arr[i]);
}

