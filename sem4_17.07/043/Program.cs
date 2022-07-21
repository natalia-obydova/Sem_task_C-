// Определить сколько чисел больше 0 введено с клавиатуры.
int num;
string str;
int count=0;
bool read=true;
void Read()
{
     System.Console.WriteLine("Введите число или ничего для выхода: ");
    str=Console.ReadLine();
    if (str == "")
        read=false;
    else 
    {
        num=Convert.ToInt32(str);
        if (num>0) count++;
    }
}
while (read)
{
   Read();
}
System.Console.WriteLine($"Введено чисел больше 0: {count}");





