/*                                        Задача 2:

 Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.*/


        
        int[] myArray = { 2, 7, 14, 5, 8, 22, 11, 16, 9, 4 };

        
        int countEven = 0;

        
        foreach (int number in myArray)
        {
            
            if (number % 2 == 0)
            {
                
                countEven++;
            }
        }

        
        Console.WriteLine("Массив: " + string.Join(", ", myArray));
        Console.WriteLine("Количество четных чисел в массиве: " + countEven);
    

