// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт максимальное.
Console.WriteLine("Введите первое целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int m = Convert.ToInt32(Console.ReadLine());
if(n > m)
{
    Console.WriteLine(n);
}

else
{
   Console.WriteLine(m); 
}
