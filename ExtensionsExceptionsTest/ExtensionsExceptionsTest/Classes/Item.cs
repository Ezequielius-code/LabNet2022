using System;
using System.Configuration;
using System.Runtime.Remoting.Messaging;

namespace ExtensionsExceptionsTest.Classes
{
	public static class Item
	{
		public static string DivideByZero(int number) 
		{
			double result = double.MinValue;
			string message;
			try
			{
				result = number / 0;
				message = $"The result of {number} divided by 0 is: {result}";
				return message;
			}
			catch (DivideByZeroException dex)
			{
				return dex.Message;
			}
			finally
			{
				if (result == double.MinValue)
				{
					Console.WriteLine("The operation has finished unsuccessfully.\n");
				}
				else
				{
					Console.WriteLine("The operation has finished successfully.\n");
				}
			}
		}

		public static string ToDivide(string number1, string number2)
		{
			string message;
			try
			{
				int result;
                int num1 = int.Parse(number1);
                int num2 = int.Parse(number2);
                result = num1 / num2;
				message = $"The result of {number1} divided by {number2} is equal to: {result}\n";
				return message;
			}
			catch (DivideByZeroException dex)
			{
				message = $"Sólo Chuck Norris divide por cero!\n{dex.Message}\n";
				return message;
			}
			catch (FormatException)
			{
				message = "Seguro ingreso una letra o no ingreso nada!\n";
				return message;
			}
		} 
	}
}
