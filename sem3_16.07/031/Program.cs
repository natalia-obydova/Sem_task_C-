// Показать кубы чисел, заканчивающихся на четную цифру

void CubesOfEven(int N)
{
    for (int i=0;i<=N;i=i+2)
    {
        int a=i*i*i;
        System.Console.WriteLine($"{i} в кубе = {a}");
    }
}
CubesOfEven(15);
