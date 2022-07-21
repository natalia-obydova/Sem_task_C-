// Показать числа Фибоначчи

int[] arr = new int [10];
int GetFibo(int i)
{
    return arr[i-2]+arr[i-1];
}

for (int i=0; i<10; i++)
{
    if (i<2) arr[i]=i;
    else arr[i]=GetFibo(i);
    System.Console.WriteLine(arr[i]);
}