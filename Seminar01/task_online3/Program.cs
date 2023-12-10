/*Внутри класса Answer напишите метод CheckIfEven, который на вход принимает число number и выводит, является ли число чётным (делится ли оно на два без остатка).

Пример использования:
На входе:


number: '6'
На выходе:


Число `6` чётное
На входе:


number: '3'
На выходе:


Число `3` нечётное*/


using System;

class Answer {
    static void CheckIfEven(int number)
    {
        if ((number % 2) == 0)
        {
            Console.WriteLine($"Число `{number}` чётное");
        }
        else
        {
            Console.WriteLine($"Число `{number}` нечётное");
        }
    }

    static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
            number = 6;
        }

        CheckIfEven(number);
    }
}
