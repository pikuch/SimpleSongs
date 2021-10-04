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
    }
}
