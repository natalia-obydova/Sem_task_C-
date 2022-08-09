// Показать кубы чисел, заканчивающихся на четную цифру

void Cube(int N)
{
    for (int i=0;i<=N;i+=2)
    {
        int a=i*i*i;
        System.Console.WriteLine($"{i} в кубе = {a}");
    }
}
Cube(15);
