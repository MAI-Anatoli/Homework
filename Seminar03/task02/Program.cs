/*                                        Задача 2:

 Задайте массив на 10 целых чисел. Напишите программу, которая определяет количество чётных чисел в массиве.*/

//int[] array = {15, 20, 37, 41, 53, 69, 73, 86, 90, 100};

void FillArray(int[] col)            
                                            
{
    int length = col.Length;         
    int index = 0;                          
    while (index < length)
    {
        col[index] = new Random().Next(1, 100);       
        index++;
    }
}


void PrintArray(int[] arr)            
{
    int count = arr.Length;          

    for (int i = 0; i < count; i++)     
    {
        Console.Write($"{arr[i]} ");  
    }
    Console.WriteLine();                
}






/*void EvenNumbers (int[] even)
{
   
    for (int i = 0; i < array.Length; i++)
    {
         int count = 0;
        if (array[i] % 2 == 0)
        {
            
            count++;
          
        }
        Console.WriteLine(count);
    }
}*/

int[] array = new int[10];

//EvenNumbers(array);
PrintArray(array);
FillArray(array);
