// Напишите программу, которая перевернёт одномерный массив (первый элемент станет 
// последним, второй – предпоследним и т.д.)



    
        int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        
        Console.WriteLine("Исходный массив:");
        PrintArray(myArray);

        
        ReverseArray(myArray);

        
        Console.WriteLine("\nПеревернутый массив:");
        PrintArray(myArray);
  

    
    static void PrintArray(int[] array)
    {
        Console.WriteLine(string.Join(", ", array));
    }

    
    static void ReverseArray(int[] array)
    {
        int leftIndex = 0;
        int rightIndex = array.Length - 1;

        while (leftIndex < rightIndex)
        {
            
            int temp = array[leftIndex];
            array[leftIndex] = array[rightIndex];
            array[rightIndex] = temp;

            
            leftIndex++;
            rightIndex--;
        }
    }

