using Practica.EF.Logic;
using Practica.EF.UI.Displays;

namespace Practica.EF.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuppliersLogic suppliersLogic = new SuppliersLogic();
            char answer = 'Y';  
            byte chosenOption;

            do
            {
                Menu.DisplayMain();
                chosenOption = Menu.GetOption();
                switch (chosenOption)
                {
                    case 1:
                        Menu.Orders();
                        break;
                    case 2:
                        Menu.DisplaySuppliers(suppliersLogic);
                        break;
                    case 3:
                        answer = 'N';
                        break;
                }
                answer = Menu.GetMenuAnswer();
            } while (answer == 'Y');
            
        }
    }
}