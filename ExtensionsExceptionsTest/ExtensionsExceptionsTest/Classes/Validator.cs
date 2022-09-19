namespace ExtensionsExceptionsTest.Classes
{
    public static class Validator
    {
        public static int ValidateOption(this string option)
        {
            int chosenOption = -1;
            if (int.TryParse(option, out chosenOption))
            {
                return chosenOption;
            }
            return chosenOption;
        }
    }
}
