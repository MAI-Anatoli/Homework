// Задайте двумерный массив.
// Напишите программу, которая поменяет местами первую и последнюю строку массива.



        
        int[,] twoDimArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        
        Console.WriteLine("Исходный массив:");
        PrintArray(twoDimArray);

        
        SwapFirstAndLastRows(twoDimArray);

        
        Console.WriteLine("\nМассив после замены первой и последней строк:");
        PrintArray(twoDimArray);
    

    
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

    
    static void SwapFirstAndLastRows(int[,] array)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        
        if (numRows >= 2)
        {
            
            int[] tempArray = new int[numCols];
            for (int j = 0; j < numCols; j++)
            {
                tempArray[j] = array[0, j];
            }

            
            for (int j = 0; j < numCols; j++)
            {
                array[0, j] = array[numRows - 1, j];
            }

            
            for (int j = 0; j < numCols; j++)
            {
                array[numRows - 1, j] = tempArray[j];
            }
        }
    }

