/*                                Задача 4**(не обязательно):

 Дано натуральное число в диапазоне от 1 до 100 000. Создайте массив, состоящий из цифр этого числа. Старший разряд числа должен располагаться на 0-м индексе массива, младший – на последнем. Размер массива должен быть равен количеству цифр.

Пример вы найдете в конце презентации к семинару.*/




       
        Console.Write("Введите натуральное число (от 1 до 100000): ");
        int inputNumber = int.Parse(Console.ReadLine());

        
        if (inputNumber < 1 || inputNumber > 100000)
        {
            Console.WriteLine("Число не соответствует диапазону от 1 до 100000.");
            return;
        }

        
        string numberString = inputNumber.ToString();

        
        int[] digitsArray = new int[numberString.Length];

        
        for (int i = 0; i < numberString.Length; i++)
        {
            digitsArray[i] = int.Parse(numberString[i].ToString());
        }

        
        Console.WriteLine("Массив цифр:");

        for (int i = 0; i < digitsArray.Length; i++)
        {
            Console.WriteLine($"digitsArray[{i}] = {digitsArray[i]}");
        }
    

