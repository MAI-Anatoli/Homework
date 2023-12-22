// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.




        
        int[,] twoDimArray = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        
        Console.Write("Введите номер строки: ");
        int rowIndex = int.Parse(Console.ReadLine());

        Console.Write("Введите номер столбца: ");
        int colIndex = int.Parse(Console.ReadLine());

        
        int result = GetArrayElementValue(twoDimArray, rowIndex, colIndex);

        
        if (result != int.MinValue)
        {
            Console.WriteLine($"Значение элемента [{rowIndex}, {colIndex}]: {result}");
        }
        else
        {
            Console.WriteLine($"Элемента с позицией [{rowIndex}, {colIndex}] не существует в массиве.");
        }
    

    
    static int GetArrayElementValue(int[,] array, int row, int col)
    {
        int numRows = array.GetLength(0);
        int numCols = array.GetLength(1);

        
        if (row >= 0 && row < numRows && col >= 0 && col < numCols)
        {
            
            return array[row, col];
        }
        else
        {
            
            return int.MinValue;
        }
    }

