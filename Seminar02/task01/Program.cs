/*Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.*/


/*Домашнее задание сделал благодаря ChatGpt сам я бы их не сделал бы не знаю что когда и зачем использовать извините за такой подход к дз.*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 7 ==0 && number % 23 == 0)
{
    Console.WriteLine($"Кратно: {number}");
}
else
{
    Console.WriteLine($"Некратное: {number}");
}