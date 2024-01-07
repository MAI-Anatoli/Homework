// Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.




        int m = 2, n = 3;
        Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");

        m = 3; n = 2;
        Console.WriteLine($"A({m}, {n}) = {AckermannFunction(m, n)}");

        Console.ReadLine();
    

    
    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (m > 0 && n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }

