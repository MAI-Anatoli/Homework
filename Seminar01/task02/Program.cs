/* Напишите программу которая принимает на вход три числа и выдает максимальное из этих чисел*/


System.Console.Write("Введите первое число: ");
int Num1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int Num2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите трете число: ");
int Num3 = Convert.ToInt32(Console.ReadLine());

int max = Num1;
if (Num2 > max) max = Num2;
if (Num3 > max) max = Num3;

Console.WriteLine($"Большое число : {max}");