/*Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.*/



/*Домашнее задание сделал благодаря ChatGpt сам я бы их не сделал бы не знаю что когда и зачем использовать извините за такой подход к дз.*/

   
        Console.WriteLine("Введите натуральное число N:");

        
        string userInput = Console.ReadLine();

        
        if (int.TryParse(userInput, out int number) && number > 0)
        {
           
            Console.Write("Цифры числа через запятую: ");
            DisplayDigitsSeparatedByComma(number);
        }
        else
        {
            Console.WriteLine("Некорректный ввод. Пожалуйста, введите натуральное число.");
        }
    

    
    static void DisplayDigitsSeparatedByComma(int num)
    {
        string digitsSeparatedByComma = "";

        
        while (num > 0)
        {
            int digit = num % 10;  
            digitsSeparatedByComma = digit + ", " + digitsSeparatedByComma;  
            num /= 10;  
        }

        Console.WriteLine(digitsSeparatedByComma.TrimEnd(',', ' '));  
    }

