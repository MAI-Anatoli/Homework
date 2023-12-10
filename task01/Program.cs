/*Напишите программу которая на входе принимает два числа и выдает какое число большее, а какое меньшее*/ 


System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int minnum, maxnum;
if(num1 > num2) 
{
    maxnum = num1;
    minnum = num2;
}
else
{
    maxnum = num2;
    minnum = num1;
}

System.Console.WriteLine($"Максимальное число : {maxnum}");
System.Console.WriteLine($"Минимальное число : {minnum}");