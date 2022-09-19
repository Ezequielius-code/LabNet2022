using System;
using System.Text;

namespace ExtensionsExceptionsTest.Classes
{
    public static class Menu
    {
        private static string SetMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("==================================================");
            stringBuilder.AppendLine("*    Extension Methods-Exceptions-Unit Tests     *");
            stringBuilder.AppendLine("==================================================");
            stringBuilder.AppendLine("|               1_Execute Item 1                 |");
            stringBuilder.AppendLine("|               2_Execute Item 2                 |");
            stringBuilder.AppendLine("|               3_Execute Item 3                 |");
            stringBuilder.AppendLine("|               4_Execute Item 4                 |");
            stringBuilder.AppendLine("==================================================\n");
            stringBuilder.AppendLine("Select option: ");

            return stringBuilder.ToString();
        }

        public static void DisplayMenu()
        {
            Console.WriteLine(SetMenu());
        }

        public static int GetSelection()
        {
            var option = Console.ReadLine();
            int chosenOption = option.ValidateOption();
            Console.Clear();
            return chosenOption;
        }

        public static void DisplayFirstMethod()
        {
            Console.WriteLine("DIVIDE BY ZERO.");
            int enteredNumber = Menu.AskNumber();
            Console.WriteLine(Item.DivideByZero(enteredNumber));
        }

        private static int AskNumber()
        {
            int aux = 0;
            bool isInteger = false;
            while (!isInteger)
            {
                Console.WriteLine("Enter a number: ");
                var enteredNumber = Console.ReadLine();
                if(int.TryParse(enteredNumber, out aux))
                {
                    isInteger = true;
                    Console.Clear();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("ERROR. You´ve entered invalid data.");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            return aux;
        }

        public static void DisplaySecondMethod()
        {
            Console.WriteLine("Enter a dividend: ");
            var dividend = Console.ReadLine();
            Console.WriteLine("Enter a divider: ");
            var divider = Console.ReadLine();
            Console.WriteLine(Item.ToDivide(dividend, divider));
        }

        public static void DisplayThirdMethod()
        {
            Console.WriteLine("ADD TO THE MAXIMUM.");
            var enteredNumber = AskNumber();
            Console.Clear();
            Logic.AddToMaximum(enteredNumber);
        }

        public static void DisplayFourthMethod()
        {
            Console.WriteLine("COUNT THE LETTERS IN YOUR WORDS.");
            Console.WriteLine("Please, enter a word to count its letters: ");
            var enteredWord = Console.ReadLine();
            Console.Clear();
            Logic.CountLetters(enteredWord);
        }

        public static void DisplayErrorMessage()
        {
            Console.WriteLine("You´ve entered an invalid option.");
        }

        public static void WaitAction()
        {
            Console.ReadKey();
            Console.Clear();
        }
    }
}
