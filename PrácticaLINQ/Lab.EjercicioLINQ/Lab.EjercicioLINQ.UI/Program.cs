using Lab.EjercicioLINQ.UI.Displays;

namespace Lab.EjercicioLINQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char answer = 'Y';
            byte chosenOption;

            do
            {
                Menu.Display();
                chosenOption = Menu.GetOption();
                switch (chosenOption)
                {
                    case 1:
                        Menu.DisplaySubMenuCustomers();
                        chosenOption = Menu.GetOption();
                        Menu.ExecuteCustomersOptions(chosenOption);
                        break;
                    case 2:
                        Menu.DisplaySubMenuProducts();
                        chosenOption = Menu.GetOption();
                        Menu.ExecuteProductOptions(chosenOption);
                        break;
                    case 3:
                        answer = 'N';
                        break;
                }
            } while (answer == 'Y');
        }
    }
}
