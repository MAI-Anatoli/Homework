// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.




        
        int M = 5;
        int N = 15;

       
        PrintNaturalNumbersInRange(M, N);

        Console.ReadLine();
    

    
    static void PrintNaturalNumbersInRange(int current, int end)
    {
        if (current <= end)
        {
            Console.Write(current + " ");
            PrintNaturalNumbersInRange(current + 1, end);
        }
    }

