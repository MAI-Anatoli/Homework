// Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.



        
        int[,] rectangularArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9},
            {10, 11, 12}
        };

       
        Console.WriteLine("Исходный массив:");
        PrintArray(rectangularArray);

        
        int minSumRowIndex = FindRowWithMinSum(rectangularArray);

        
        Console.WriteLine($"\nСтрока с наименьшей суммой элементов: {minSumRowIndex}");
    

    
    static void PrintArray(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        for (int i = 0; i < numRows; i++)
        {
            for (int j = 0; j < numCols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    
    static int FindRowWithMinSum(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        
        int minSum = int.MaxValue;

        
        int minSumRowIndex = -1;

        for (int i = 0; i < numRows; i++)
        {
           
            int currentSum = 0;
            for (int j = 0; j < numCols; j++)
            {
                currentSum += array[i, j];
            }

            
            if (currentSum < minSum)
            {
                minSum = currentSum;
                minSumRowIndex = i;
            }
        }

        return minSumRowIndex;
    }

