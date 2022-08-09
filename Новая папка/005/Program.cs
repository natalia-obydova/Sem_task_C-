/*Вводится число N, а затем - N чисел. Определить, сколько среди них пар одинаковых чисел, стоящих рядом.
100>=N>=2
Пример входного файла:
5
1 3 2 2 3
*/

Console.WriteLine("Введите N");
string? s=Console.ReadLine();
string[] ss=s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
int[] a=Array.ConvertAll<string,int>(ss, int.Parse);

for(int i=0;i<a.Length;i=i+2)
    System.Console.Write($"{a[i]} ");    
for(int i=1;i<a.Length;i=i+2)
    System.Console.Write($"{a[i]} ");

