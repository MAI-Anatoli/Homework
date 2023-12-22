// Задайте массив заполненный случайными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.



    
        
        int arraySize = 10;

        
        int[] randomArray = GenerateRandomArray(arraySize);

        
        Console.WriteLine("Массив случайных трехзначных чисел:");
        PrintArray(randomArray);

        
        int countEvenNumbers = CountEvenNumbers(randomArray);

       
        Console.WriteLine($"Количество четных чисел в массиве: {countEvenNumbers}");
    

    
    static int[] GenerateRandomArray(int size)
    {
        Random random = new Random();
        int[] array = new int[size];

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000); 
        }

        return array;
    }

    
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    
    static int CountEvenNumbers(int[] array)
    {
        int count = 0;

        foreach (int number in array)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
    }

