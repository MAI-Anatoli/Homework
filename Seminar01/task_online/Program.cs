/*Внутри класса Answer напишите метод CompareNumbers, который на вход принимает два числа и выводит, какое число большее, а какое меньшее.

Пример использования:
На входе:


firstNumber: '5'
secondNumber: '6'
На выходе:


Первое число `5` меньше чем второе число `6`
На входе:


firstNumber: '3'
secondNumber: '6'
На выходе:


Первое число `3` меньше чем второе число `6`
На входе:


firstNumber: '3'
secondNumber: '3'
На выходе:


Введенные числа равны `3`*/


/*using System;

public class Answer {
    static void CompareNumbers(int firstNumber, int secondNumber)
    {*/
        if (firstNumber == secondNumber)
        {
            Console.WriteLine($"Введенные числа равны `{firstNumber}`");
        }
        if (firstNumber > secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` больше чем второе число `{secondNumber}`");
        }
        if (firstNumber < secondNumber)
        {
            Console.WriteLine($"Первое число `{firstNumber}` меньше чем второе число `{secondNumber}`");
        }
 /*   }

    static public void Main(string[] args) {
        int firstNumber, secondNumber;

        if (args.Length >= 2) {
            firstNumber = int.Parse(args[0]);
            secondNumber = int.Parse(args[1]);
        } else {
            firstNumber = 5;
            secondNumber = 5;
        }

        CompareNumbers(firstNumber, secondNumber);
    }
}*/
