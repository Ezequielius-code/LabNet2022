namespace Lab.EjercicioLINQ.Commons
{
    public static class IOValidator
    {
        public static byte ValidateEnteredNumber(this string option)
        {
            byte chosenOption = 0;
            if (byte.TryParse(option, out chosenOption))
            {
                return chosenOption;
            }
            return chosenOption;
        }
    }
}
