Console.WriteLine("Введите целое число");
int n = Convert.ToInt32(Console.ReadLine());
if(0 == n % 2)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}