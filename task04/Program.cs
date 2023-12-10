/* Напишите программу которая на вход принимает число N, а на выходе показывает все четные числа от 1 до N.*/

System.Console.WriteLine("Жду число: ");
int num =Convert.ToInt32(Console.ReadLine());
int numStart = 2;
while (numStart <= num )
{
    System.Console.Write($"{numStart}  ");
    numStart += 2;
}