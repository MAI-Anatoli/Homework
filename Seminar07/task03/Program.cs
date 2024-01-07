// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.



        
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

       
        PrintArrayReverse(array, array.Length - 1);

        Console.ReadLine();
    

   
    static void PrintArrayReverse(int[] arr, int index)
    {
        if (index >= 0)
        {
            Console.Write(arr[index] + " ");
            PrintArrayReverse(arr, index - 1);
        }
    }

