/*Напишите программу которая на входе принимает два числа и выдает какое число большее, а какое меньшее*/ 

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

//int minnum, maxnum;
if(num1 > num2) 
{
    Console.WriteLine($"Число: {num2} меньше числа: {num1}");
    //maxnum = num1;
    //minnum = num2;
}
else if(num1 < num2)
{
    Console.WriteLine($"Число: {num1} меньше числа: {num2}");
    //maxnum = num2;
    //minnum = num1;
}
else
{
    Console.WriteLine($"Введенные числа равны `{num1}`");
   //Console.WriteLine($"Число: {num1} и число: {num2} равны");
   //return;
}
     //Console.WriteLine($"Число: {minnum} меньше числа: {maxnum} ");

//System.Console.WriteLine($"Максимальное число : {maxnum}");
//System.Console.WriteLine($"Минимальное число : {minnum}");