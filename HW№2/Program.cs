//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое целое число");
int k = Convert.ToInt32(Console.ReadLine());
if(n > m)
{
    if(n > k)
    {
        Console.WriteLine(n);
    }
    else
    {
        Console.WriteLine(k);
    }
}
else 
{
    if(m > k)
    {
       Console.WriteLine(m); 
    }
    else
    {
        Console.WriteLine(k);
    }
}
