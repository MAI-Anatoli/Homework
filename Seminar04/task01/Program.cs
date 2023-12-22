//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



    
        while (true)
        {
            Console.Write("Введите целое число или 'q' для завершения: ");
            string input = Console.ReadLine();

            
            if (input.ToLower() == "q")
            {
                Console.WriteLine("Программа завершена по запросу пользователя.");
                break;
            }

            
            if (int.TryParse(input, out int number))
            {
                
                if (IsSumOfDigitsEven(number))
                {
                    Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                    break;
                }
                else
                {
                    Console.WriteLine($"Сумма цифр числа {number} нечётная. Продолжайте ввод.");
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите целое число или 'q' для завершения.");
            }
        }
   

    
    static bool IsSumOfDigitsEven(int num)
    {
        int sum = 0;

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum % 2 == 0;
    }

