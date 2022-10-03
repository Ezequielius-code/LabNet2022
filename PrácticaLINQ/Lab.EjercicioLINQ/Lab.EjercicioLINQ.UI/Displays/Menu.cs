using Lab.EjercicioLINQ.Commons;
using Lab.EjercicioLINQ.Entities;
using Lab.EjercicioLINQ.Entities.DTO;
using Lab.EjercicioLINQ.Logic;
using System;
using System.Text;

namespace Lab.EjercicioLINQ.UI.Displays
{
    public static class Menu
    {
        private static string SetMainMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("_______________________________________________________");
            stringBuilder.AppendLine("*                        QUERIES                      *");
            stringBuilder.AppendLine("-------------------------------------------------------");
            stringBuilder.AppendLine("|                  1_Queries on Customers             |");
            stringBuilder.AppendLine("|                  2_Queries on Products              |");
            stringBuilder.AppendLine("|                  3_Exit                             |");
            stringBuilder.AppendLine("|_____________________________________________________|");
            stringBuilder.AppendLine("Select option: ");

            return stringBuilder.ToString();
        }

        public static void Display()
        {
            Console.WriteLine(SetMainMenu());
        }

        public static byte GetOption()
        {
            var option = Console.ReadLine();
            byte chosenOption = option.ValidateEnteredNumber();
            Console.Clear();
            return chosenOption;
        }

        private static string SetCustomersMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("_______________________________________________________");
            stringBuilder.AppendLine("*                  QUERIES ON CUSTOMERS               *");
            stringBuilder.AppendLine("-------------------------------------------------------");
            stringBuilder.AppendLine("|         1_Get Customer by Id                        |");
            stringBuilder.AppendLine("|         2_Get Customers From WA                     |");
            stringBuilder.AppendLine("|         3_Get Customers Upper & Lower case          |");
            stringBuilder.AppendLine("|         4_Get Customers from WA (Orders after 1997) |");
            stringBuilder.AppendLine("|         5_Get Customers from WA (TOP 3)             |");
            stringBuilder.AppendLine("|         6_Get Customers with associate orders       |");
            stringBuilder.AppendLine("|         7_Exit                                      |");
            stringBuilder.AppendLine("|_____________________________________________________|");
            stringBuilder.AppendLine("Select option: ");

            return stringBuilder.ToString();
        }

        public static void DisplaySubMenuCustomers()
        {
            Console.WriteLine(SetCustomersMenu());
        }

        private static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public static void ExecuteCustomersOptions(byte option)
        {
            switch (option)
            {
                case 1:
                    ExecuteCustomersOption1();
                    PressKeyToContinue();
                    break;
                case 2:
                    ExecuteCustomersOption2();
                    PressKeyToContinue();
                    break;
                case 3:
                    ExecuteCustomersOption3();
                    PressKeyToContinue();
                    break;
                case 4:
                    ExecuteCustomersOption4();
                    PressKeyToContinue();
                    break;
                case 5:
                    ExecuteCustomersOption5();
                    PressKeyToContinue();
                    break;
                case 6:
                    ExecuteCustomersOption6();
                    PressKeyToContinue();
                    break;
                default:
                    break;
            }
        }

        private static void ExecuteCustomersOption1()
        {
            CustomerQueryLogic cql = new CustomerQueryLogic();
            foreach (var item in cql.GetCustomersId())
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Enter Id: ");
            string enteredId = Console.ReadLine();
            Console.Clear();
            Console.WriteLine(cql.GetCustomerById(enteredId));
        }

        private static void ExecuteCustomersOption2()
        {
            CustomerQueryLogic cql = new CustomerQueryLogic();
            foreach (Customers customer in cql.CustomersInWA())
            {
                Console.WriteLine(customer.ToString() + $"    -Region: {customer.Region}");
            }
        }

        private static void ExecuteCustomersOption3()
        {
            CustomerQueryLogic cql = new CustomerQueryLogic();
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("Customers upper an lower");
            foreach (string companyName in cql.CustomersNamesUpLow())
            {
                stringBuilder.AppendLine($"Company name: {companyName.ToUpper()}");
                stringBuilder.AppendLine($"Company name: {companyName.ToLower()}\n");
            }
            Console.WriteLine(stringBuilder.ToString());
        }

        private static void ExecuteCustomersOption4()
        {
            CustomerQueryLogic cql = new CustomerQueryLogic();
            foreach (var item in cql.CustomersFromWAWithOrders())
            {
                Console.WriteLine($"Company name: {item.CompanyName} // Region: {item.Region}\n" +
                                  $"Order Id: {item.OrderID} // Order Date: {Convert.ToDateTime(item.OrderDate):dd/MM/yyyy}");
            }
        }

        private static void ExecuteCustomersOption5()
        {
            CustomerQueryLogic cql = new CustomerQueryLogic();
            foreach (Customers customer in cql.CustomersInWA())
            {
                Console.WriteLine(customer.ToString() + $"    -Region: {customer.Region}");
            }
        }

        private static void ExecuteCustomersOption6()
        {
            CustomerQueryLogic cql = new CustomerQueryLogic();
            foreach (var item in cql.GetCustomersWithAssociateOrders())
            {
                Console.WriteLine($"Customer: {item.CompanyName} // Number of Orders: {item.NumberOfOrders}\n");
            }
        }

        private static string SetProductsMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("_______________________________________________________");
            stringBuilder.AppendLine("*                  QUERIES ON Products                *");
            stringBuilder.AppendLine("-------------------------------------------------------");
            stringBuilder.AppendLine("|         1_Get Products out of stock                 |");
            stringBuilder.AppendLine("|         2_Get Products in stock (Price: >$3)        |");
            stringBuilder.AppendLine("|         3_Get first Product with ID = 789           |");
            stringBuilder.AppendLine("|         4_Get Products ordered by name              |");
            stringBuilder.AppendLine("|         5_Get Products ordered by units in stock    |");
            stringBuilder.AppendLine("|         6_Get Products with its categories          |");
            stringBuilder.AppendLine("|         7_Get first Product from list               |");
            stringBuilder.AppendLine("|         8_Exit                                      |");
            stringBuilder.AppendLine("|_____________________________________________________|");
            stringBuilder.AppendLine("Select option: ");

            return stringBuilder.ToString();
        }

        public static void DisplaySubMenuProducts()
        {
            Console.WriteLine(SetProductsMenu());
        }

        public static void ExecuteProductOptions(byte option)
        {
            switch (option)
            {
                case 1:
                    ExecuteProductsOption1();
                    PressKeyToContinue();
                    break;
                case 2:
                    ExecuteProductsOption2();
                    PressKeyToContinue();
                    break;
                case 3:
                    ExecuteProductsOption3();
                    PressKeyToContinue();
                    break;
                case 4:
                    ExecuteProductsOption4();
                    PressKeyToContinue();
                    break;
                case 5:
                    ExecuteProductsOption5();
                    PressKeyToContinue();
                    break;
                case 6:
                    ExecuteProductsOption6();
                    PressKeyToContinue();
                    break;
                case 7:
                    ExecuteProductsOption7();
                    PressKeyToContinue();
                    break;
                default:
                    break;
            }
        }

        private static void ExecuteProductsOption1()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            foreach (Products product in pql.ProductsOutOfStock())
            {
                Console.WriteLine(product.ToString());
            }
        }

        private static void ExecuteProductsOption2()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            foreach (Products product in pql.ProductsMoreExpensiveThan3WithStock())
            {
                Console.WriteLine(product.ToString());
            }
        }

        private static void ExecuteProductsOption3()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            Console.WriteLine(pql.GetProductWithId789());
        }

        private static void ExecuteProductsOption4()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            foreach (Products product in pql.ProductsOrderedByName())
            {
                Console.WriteLine(product.ToString());
            }
        }

        private static void ExecuteProductsOption5()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            foreach (Products product in pql.ProductsOrderedByDescendingStock())
            {
                Console.WriteLine(product.ToString());
            }
        }

        private static void ExecuteProductsOption6()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            foreach (ProductCategory product in pql.GetProductsWithAssociatesCategories())
            {
                Console.WriteLine($"Id Category: {product.CategoryID} // Category: {product.CategoryName} // Product: {product.ProductName}");
            }
        }

        private static void ExecuteProductsOption7()
        {
            ProductQueryLogic pql = new ProductQueryLogic();
            Console.WriteLine($"First product found:\n{pql.GetFirstProduct()}");
        }
    }
}
