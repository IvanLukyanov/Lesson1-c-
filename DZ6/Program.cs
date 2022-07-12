/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Чтобы узнать четное число или нет и делится ли оно на два без остатка: ");
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int remain = n % 2;
if (remain == 0) Console.WriteLine("Число " +n+ " четное!");
else Console.WriteLine("Число " +n+ " нечетное!");
if (remain == 0)
{
    Console.WriteLine("Число " +n+ " четное?");
    Console.WriteLine("ДА!");
}
else
{
    Console.WriteLine("Число " +n+ " четное?");
    Console.WriteLine("НЕТ!");
}