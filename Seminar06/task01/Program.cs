// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.


        
        char[,] charArray = {
            {'H', 'e', 'l', 'l', 'o'},
            {'W', 'o', 'r', 'l', 'd'}
        };

       
        string resultString = GetStringFromCharArray(charArray);

        
        Console.WriteLine("Исходный массив символов:");
        PrintCharArray(charArray);

        Console.WriteLine("\nСтрока из символов массива:");
        Console.WriteLine(resultString);
    

    
    static string GetStringFromCharArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        
        System.Text.StringBuilder sb = new System.Text.StringBuilder();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sb.Append(array[i, j]);
            }
        }

        return sb.ToString();
    }

    
    static void PrintCharArray(char[,] array)
    {
        int rows = array.GetLength(0);
        int cols = array.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

