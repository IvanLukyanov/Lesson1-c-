/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Чтобы узнать какое число большее, а какое меньшее");
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n > m)
{    Console.WriteLine("Число" +n+ "большее");
     Console.WriteLine("Число" +m+ "меньшее");
}
if(n == m)
{
     Console.WriteLine("Число" +n+ "равно Числу" +m);
}
else
{
     Console.WriteLine("Число" +m+ "большее ");
     Console.Write("Число" +n+ "меньшее ");
}
