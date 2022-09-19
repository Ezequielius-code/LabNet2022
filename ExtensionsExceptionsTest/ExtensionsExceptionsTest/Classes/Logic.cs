using System;

namespace ExtensionsExceptionsTest.Classes
{
    public class Logic
    {
        public static void AddToMaximum(int number)
        {
            try
            {
                checked
                {
                    int maxNumber = int.MaxValue;
                    int result = maxNumber + number;
                    Console.WriteLine($"The max number is: {result}");
                }
            }
            catch
            {
                throw;
            }
        }

        public static string CountLetters(string word)
        {
            int counter = 1;
            if (word.Length > 0 || word == null || word == "")
            {
                throw new OutOfMemoryException("OUT OF MEMORY EXCEPTION. - The app can´t execute this action.\n" +
                                               "Please, delete unuseful data in your device.");
            }
            else
            {
                for (int i = 0; i < word.Trim().Length; i++)
                {
                    counter++;
                }
                return $"Your word has {counter} letters.";
            }
        }
    }
}
