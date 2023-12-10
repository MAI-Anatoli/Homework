/*Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и 
выдаёт номер координатной четверти плоскости, в которой находится эта точка.*/


/*Домашнее задание сделал благодаря ChatGpt сам я бы их не сделал бы не знаю что когда и зачем использовать извините за такой подход к дз.*/


Console.WriteLine("Введите координаты X: ");
double x = double.Parse(Console.ReadLine()); 
Console.WriteLine("Введите координаты Y: ");
double y = double.Parse(Console.ReadLine());

if (x != 0 && y != 0)
{                              
if (x > 0 && y > 0)
{
                                                     
    Console.WriteLine("I квадрант");
}
else if (x < 0 && y > 0)
{
                                                       
    Console.WriteLine("II квадрант");
}
else if (x < 0 && y < 0)
{
    
    Console.WriteLine("III квадрант");
}
else if (x > 0 && y < 0)
{
    
    Console.WriteLine("IV квадрант");
}
else if (x == 0 && y == 0)
{
    
    Console.WriteLine("Начало координат");
}
}