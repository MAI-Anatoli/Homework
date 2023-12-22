// Задайте произвольную строку. Выясните, является ли она палиндромом.




        
        string inputString = "level";

        
        bool isPalindrome = IsPalindrome(inputString);

       
        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Является ли строка палиндромом: " + isPalindrome);
   

    
    static bool IsPalindrome(string str)
    {
        
        char[] charArray = str.ToCharArray();

        
        Array.Reverse(charArray);

        
        string reversedString = new string(charArray);

        
        return str.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
    }

