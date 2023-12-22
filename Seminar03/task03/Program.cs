/*                                        Задача 3:

 Задайте массив из вещественных чисел с ненулевой дробной частью. Найдите разницу между максимальным и минимальным элементов массива.*/

 double[] myArray = { 3.14, 2.71, 5.55, 1.23, 4.78, 6.66, 9.99, 8.88, 7.77, 10.1 };

        
        double minElement = myArray[0];
        double maxElement = myArray[0];

        foreach (double number in myArray)
        {
            if (number < minElement)
            {
                minElement = number;
            }

            if (number > maxElement)
            {
                maxElement = number;
            }
        }

       
        double difference = maxElement - minElement;

       
        Console.WriteLine("Массив: " + string.Join(", ", myArray));
        Console.WriteLine("Минимальный элемент: " + minElement);
        Console.WriteLine("Максимальный элемент: " + maxElement);
        Console.WriteLine("Разница между максимальным и минимальным элементами: " + difference);
 



