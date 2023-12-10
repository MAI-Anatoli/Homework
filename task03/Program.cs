/* Напишите программу которая на вход принимает число и выдает является ли число четным (делится ли она на два без остатка)*/

System.Console.WriteLine("Жду число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number % 2 == 0)
{
    System.Console.WriteLine($"Четное: {Number} ");
}
else
{
    System.Console.WriteLine($"Не четное: {Number} ");
}