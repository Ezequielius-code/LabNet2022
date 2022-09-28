namespace Practica.EF.Commons
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

        public static char ValidateEnteredCharacter(this char answer)
        {
            switch (answer)
            {
                case 'Y':
                    return answer;
                case 'N':
                    return answer;
                default:
                    return 'E';
            }
        }

        public static int ValidateEnteredIntNumber(this string option)
        {
            int chosenOption = 0;
            if (int.TryParse(option, out chosenOption))
            {
                return chosenOption;
            }
            return chosenOption;
        }
    }
}
