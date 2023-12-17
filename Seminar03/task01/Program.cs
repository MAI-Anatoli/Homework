/*                                Задача 1: 

Задайте одномерный массив из 10 целых чисел от 1 до 100. Найдите количество элементов массива, значения которых лежат в отрезке [20,90].*/


int[] elements = {15, 20, 37, 41, 53, 69, 73, 86, 90, 100};

/* void PrintArray(int[] array)
{
    int count = array.Length;
    int possition = 0;
    while (possition < count)
    {
        System.Console.WriteLine(array[possition]);
        possition++;
    }
}*/

//int[] elements = new int[10];

/*void FillArray(int[] collection)            
                                            
{
    int length = collection.Length;         
    int index = 0;                          
    while (index < length)
    {
        collection[index] = new Random().Next(1, 100);       
        index++;
    }
}*/

void FindingElements(int[] elements)
{

    int number = 0;
    for (int i = 0; i < elements.Length; i++)
    {
        if (90 > elements[i])
        {
            if(elements[i] > 20)
            {
                number++;
            }
            Console.WriteLine();
            Console.WriteLine(elements[i] + " ");
        }

    }
    Console.WriteLine();
    Console.WriteLine(number);
}
//PrintArray(elements);
//FillArray(elements);
FindingElements(elements);
