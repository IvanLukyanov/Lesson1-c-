/*Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Чтобы узнать, какое из трех числе имеет максимальное значение.");
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int l = Convert.ToInt32(Console.ReadLine());
int maxNumber = 0;
if (n > maxNumber) maxNumber = n;
if (m > maxNumber) maxNumber = m;
if (l > maxNumber) maxNumber = l;

Console.Write("Максимальное значение имеет число " + maxNumber);