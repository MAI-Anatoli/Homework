// Задайте строку, содержащую латинские буквы в обоих регистрах.
// Сформируйте строку, в которой все заглавные буквы заменены на строчные.



        
        string inputString = "Hello World";

        
        string resultString = ConvertToLowerCase(inputString);

        
        Console.WriteLine("Исходная строка: " + inputString);
        Console.WriteLine("Строка с заменой заглавных букв на строчные: " + resultString);
    

    
    static string ConvertToLowerCase(string input)
    {
        
        return input.ToLower();
    }

