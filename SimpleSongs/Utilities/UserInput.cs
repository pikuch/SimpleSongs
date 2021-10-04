using System;

namespace SimpleSongs.Utilities
{
    public static class UserInput
    {

        public static string GetString(string prompt, int minLength, int maxLength)
        {
            string input = String.Empty;
            bool isValid = false;

            Console.Clear();
            while (!isValid)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (input.Length < minLength)
                {
                    Console.WriteLine($"String too short (<{minLength})");
                }
                else if (input.Length > maxLength)
                {
                    Console.WriteLine($"String too long (>{maxLength})");
                }
                else
                {
                    isValid = true;
                }
            }
            return input;
        }

        public static int GetInt(string prompt, int minValue, int maxValue)
        {
            string input = String.Empty;
            int intInput = 0;
            bool isValid = false;

            Console.Clear();
            while (!isValid)
            {
                Console.WriteLine(prompt);
                input = Console.ReadLine();
                if (int.TryParse(input, out intInput))
                {
                    if (intInput < minValue || intInput > maxValue)
                    {
                        Console.WriteLine($"Number has to be between {minValue} and {maxValue}");
                    }
                    else
                    {
                        isValid = true;
                    }
                    
                } else
                {
                    Console.WriteLine($"Not a number");
                }
            }
            return intInput;
        }
    }
}
