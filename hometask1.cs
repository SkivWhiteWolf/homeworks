
// Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9
Console.WriteLine("Введите первое число");
string a = Console.ReadLine();
int a1 = Convert.ToInt32(a);
Console.WriteLine("Введите второе число");
string b = Console.ReadLine();
int b1 = Convert.ToInt32(b);
if ( a1 > b1 )
{
    Console.WriteLine($"max= {a1}"  );
    Console.WriteLine($"min= {b1}"  );
    }
else
{
 Console.WriteLine($"max= {b1} ");
Console.WriteLine($"min= {a1} " );
   }