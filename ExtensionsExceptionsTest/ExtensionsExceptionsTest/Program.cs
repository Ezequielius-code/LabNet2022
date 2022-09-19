using ExtensionsExceptionsTest.Classes;
using System;

namespace ExtensionsExceptionsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char answer = 'Y';
            int chosenOption = 0;

            do
            {
                Menu.DisplayMenu();
                chosenOption = Menu.GetSelection();
                switch (chosenOption)
                {
                    case 1:
                        Menu.DisplayFirstMethod();
                        Menu.WaitAction();
                        break;
                    case 2:
                        Menu.DisplaySecondMethod();
                        Menu.WaitAction();
                        break;
                    case 3:
                        try
                        {
                            Menu.DisplayThirdMethod();
                        }
                        catch (OverflowException oex)
                        {
                            Console.WriteLine($"{oex.Message}\n");
                            Console.WriteLine(typeof(OverflowException).ToString());
                            Menu.WaitAction();
                        }
                        break;
                    case 4:
                        try
                        {
                            Menu.DisplayFourthMethod();
                        }
                        catch (OutOfMemoryException oex)
                        {
                            Console.WriteLine($"{oex.Message}\n");
                            Console.WriteLine(typeof(OutOfMemoryException).ToString());
                            Menu.WaitAction();
                        }
                        break;
                    default:
                        Menu.DisplayErrorMessage();
                        Menu.WaitAction();
                        break;
                }
                Console.WriteLine("Do you want to keep running the app?\n\t'Y'es - 'N'o");
                answer = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            } while (answer == 'Y');
        }
    }
}
