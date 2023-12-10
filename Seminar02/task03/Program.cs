/*  Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа. */



/*Домашнее задание сделал благодаря ChatGpt сам я бы их не сделал бы не знаю что когда и зачем использовать извините за такой подход к дз.*/


Console.WriteLine("Введите число с 10 до 99: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num  >= 10 && num <=99)
{
    int maxDigit = 0;

    while ( num > 0)
    {
       int digit = num % 10;
        maxDigit = Math.Max(maxDigit, digit);
        num /= 10; 
    }
    Console.WriteLine($"Наибольшая цифра числа: {maxDigit}" );
}