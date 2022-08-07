Console.WriteLine("Введите первое целое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе целое число");
int m = Convert.ToInt32(Console.ReadLine());
if(n == m * m)
{
    Console.WriteLine("да");
}

else
{
   Console.WriteLine("нет"); 
}


// if(result.ToLower() == m)
// {
//     Console.Write("Ура подходит!");
// }
// else
// {
//     Console.Write("К сожалению нет ");
//     Console.WriteLine(result);
// }
