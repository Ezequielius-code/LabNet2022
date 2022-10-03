using Practica.EF.Commons;
using Practica.EF.Entities;
using Practica.EF.Logic;
using System;
using System.Text;

namespace Practica.EF.UI.Displays
{
    public static class Menu
    {
        private static string SetMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("==================================================");
            stringBuilder.AppendLine("*           ORDERS & SUPPLIERS TRACKING          *");
            stringBuilder.AppendLine("==================================================");
            stringBuilder.AppendLine("|                1_Track Orders                  |");
            stringBuilder.AppendLine("|                2_See Suppliers                 |");
            stringBuilder.AppendLine("|                3_Exit                          |");
            stringBuilder.AppendLine("==================================================\n");
            stringBuilder.AppendLine("Select option: ");

            return stringBuilder.ToString();
        }

        internal static void DisplayMain()
        {
            System.Console.WriteLine(SetMenu());
        }

        internal static byte GetOption()
        {
            var option = Console.ReadLine();
            byte chosenOption = option.ValidateEnteredNumber();
            Console.Clear();
            return chosenOption;
        }

        private static string SetOrdersMenu()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("==================================================");
            stringBuilder.AppendLine("*                   ORDERS MENU                  *");
            stringBuilder.AppendLine("==================================================");
            stringBuilder.AppendLine("|            1_Display list of orders            |");
            stringBuilder.AppendLine("|            2_Create a new order                |");
            stringBuilder.AppendLine("|            3_Update an existing order          |");
            stringBuilder.AppendLine("|            4_Cancel an existing order          |");
            stringBuilder.AppendLine("|                (DELETE the order)              |");
            stringBuilder.AppendLine("|            5_Exit                              |");
            stringBuilder.AppendLine("==================================================\n");
            stringBuilder.AppendLine("Select option: ");

            return stringBuilder.ToString();
        }

        internal static void DisplayOrdersMenu()
        {
            Console.WriteLine(SetOrdersMenu());
        }

        internal static void DisplayOrdersSelectedOption(byte option)
        {
            OrdersLogic ordersLogic = new OrdersLogic();
            ProductsLogic productsLogic = new ProductsLogic();
            Order_DetailsLogic orderDetailsLogic = new Order_DetailsLogic();
            switch (option)
            {
                case 1:
                    DisplayOrders(ordersLogic);
                    Menu.PressKeyToContinue();
                    break;
                case 2:
                    byte chosedProduct;
                    byte chosedQuantity;
                    int chosedShipVia;
                    Menu.OrdersHeader();
                    Menu.DisplayProducts(productsLogic);
                    Console.WriteLine("\nEnter the product Id you want to order: ");
                    chosedProduct = Menu.GetOption();
                    if (EntitiesValidator.IsValidProduct(productsLogic, chosedProduct))
                    {
                        Console.WriteLine("You´ve made a great choice!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, something went wrong.");
                        break;
                    }
                    Console.WriteLine("\nEnter the quantity you want to order: ");
                    chosedQuantity = Menu.GetOption();
                    if (EntitiesValidator.IsValidQuantity(productsLogic, chosedProduct, chosedQuantity))
                    {
                        Console.WriteLine("You´ve finished with this, let´s arrange your order.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, something went wrong.");
                        break;
                    }
                    Menu.PressKeyToContinue();
                    Console.WriteLine("Select Ship via: ");
                    Console.WriteLine("\t1-Plane\n\t2-Ship\n\t3-Any");
                    chosedShipVia = Convert.ToInt32(Menu.GetOption());
                    if (EntitiesValidator.IsValidShipVia(chosedShipVia))
                    {
                        Console.WriteLine("Thank you! Your order is being processed.");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, something went wrong.");
                        break;
                    }
                    Menu.PressKeyToContinue();

                    Random rand = new Random();
                    Orders order = new Orders
                    {
                        OrderDate = DateTime.Now,
                        RequiredDate = DateTime.Now.AddDays(rand.Next(15, 31)),
                        ShipVia = chosedShipVia
                    };
                    ordersLogic.Add(order);

                    Order_Details orderDetails = new Order_Details
                    {
                        OrderID = order.OrderID,
                        ProductID = chosedProduct,
                        Quantity = chosedQuantity
                    };
                    orderDetailsLogic.Add(orderDetails);

                    productsLogic.UpdateOrderRequested(orderDetails);
                    Console.WriteLine("Your order was successfully sent.");
                    Menu.PressKeyToContinue();
                    break;
                case 3:
                    byte chosedOption;
                    int orderSelected;
                    Console.WriteLine("What do you want to modify?\n\t1-ShipVia\n\t2-Order quantity\nEnter option: ");
                    chosedOption = Menu.GetOption();
                    switch (chosedOption)
                    {
                        case 1:
                            int newShipVia;
                            Menu.DisplayOrders(ordersLogic);
                            Console.WriteLine("Select the order you want modify by its Id: ");
                            orderSelected = Menu.GetIntOption();
                            if (EntitiesValidator.IsValidOrderId(ordersLogic, orderSelected))
                            {
                                Orders orderToBeModified = ordersLogic.GetOrderById(orderSelected);
                                Console.WriteLine($"ORDER:\n■Order Id: {orderToBeModified.OrderID} ■Ship Via: {orderToBeModified.ShipVia}" +
                                                  $"■Quantity: {ordersLogic.GetOrderQuantity(orderToBeModified, orderDetailsLogic)}\n");
                                Console.WriteLine("Select new Ship via: ");
                                Console.WriteLine("\t1-Plane\n\t2-Ship\n\t3-Any");
                                newShipVia = Menu.GetOption();
                                if (EntitiesValidator.IsValidShipVia(newShipVia))
                                {
                                    Orders orderToUpdate = new Orders { OrderID = orderSelected, ShipVia = newShipVia };
                                    ordersLogic.Update(orderToUpdate);
                                    Console.WriteLine("Your order was modified successfully.");
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, something went wrong.");
                                    break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, something went wrong.");
                                break;
                            }
                            break;
                        case 2:
                            byte newQuantity;
                            Menu.DisplayOrders(ordersLogic);
                            Console.WriteLine("Select the order you want to modify by its Id: ");
                            orderSelected = Menu.GetIntOption();
                            if (EntitiesValidator.IsValidOrderId(ordersLogic, orderSelected))
                            {
                                Orders orderToBeModified = ordersLogic.GetOrderById(orderSelected);
                                Console.WriteLine($"ORDER:\n■Order Id: {orderToBeModified.OrderID} ■Ship Via: {orderToBeModified.ShipVia}" +
                                                  $"■Quantity: {ordersLogic.GetOrderQuantity(orderToBeModified, orderDetailsLogic)}\n");
                                Console.WriteLine("Enter new quantity: ");
                                newQuantity = Menu.GetOption();
                                if (newQuantity > 0 && newQuantity < ordersLogic.GetOrderQuantity(orderToBeModified, orderDetailsLogic))
                                {
                                    ordersLogic.RemoveOrderStock(orderToBeModified, newQuantity, orderDetailsLogic, productsLogic);
                                }
                                else if (newQuantity > ordersLogic.GetOrderQuantity(orderToBeModified, orderDetailsLogic))
                                {
                                    ordersLogic.AddOrderStock(orderToBeModified, newQuantity, orderDetailsLogic, productsLogic);
                                }
                                else
                                {
                                    Console.WriteLine("Sorry, something went wrong.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Sorry, something went wrong.");
                                break;
                            }
                            break;
                    }
                    break;
                case 4:
                    int orderToBeDeleted;
                    Menu.DisplayOrders(ordersLogic);
                    Console.WriteLine("Select the order you want to delete by its Id: ");
                    orderToBeDeleted = Menu.GetIntOption();
                    if (EntitiesValidator.IsValidOrderId(ordersLogic, orderToBeDeleted))
                    {
                        ordersLogic.ToDelete(orderToBeDeleted, ordersLogic, orderDetailsLogic, productsLogic);
                    }
                    else
                    {
                        Console.WriteLine("Sorry, something went wrong.");
                        break;
                    }
                    break;
            }
        }

        internal static void OrdersHeader()
        {
            Console.WriteLine("Welcome! Here your order begins.");
            Console.WriteLine("Please select the product you want to order by its number: ");
        }

        internal static void DisplayOrders(OrdersLogic ordersLogic)
        {
            short count = 1;
            foreach (Orders order in ordersLogic.GetAll())
            {
                Console.WriteLine($"ORDER #{count}:");
                Console.WriteLine($"ID: {order.OrderID} - Date: {Convert.ToDateTime(order.OrderDate).ToString("MM/dd/yyyy")} - " +
                                  $"Shipped date: {Convert.ToDateTime(order.ShippedDate).ToString("MM/dd/yyyy")}");
                Console.WriteLine($"Ship via: {order.ShipVia} - Freight: {order.Freight} - Ship name: {order.ShipName}\n");
                count++;
            }
        }

        internal static void DisplayProducts(ProductsLogic productsLogic)
        {
            foreach (Products product in productsLogic.GetAll())
            {
                if (product.UnitsInStock > 0)
                {
                    Console.WriteLine("PRODUCT:");
                    Console.WriteLine($"■ID: {product.ProductID}   ■Name: {product.ProductName}   ■Stock: {product.UnitsInStock}");
                }
            }
        }

        internal static void Orders()
        {
            byte chosenOption;
            char subMenuAnswer = 'Y';
            do
            {
                Menu.DisplayOrdersMenu();
                chosenOption = Menu.GetOption();
                if (chosenOption == 5)
                {
                    subMenuAnswer = 'N';
                }
                else
                {
                    Menu.DisplayOrdersSelectedOption(chosenOption);
                }
                do
                {
                    try
                    {
                        subMenuAnswer = Menu.GetSubMenuAnswer();
                        if (subMenuAnswer == 'N')
                        {
                            Menu.PressKeyToContinue();
                            break;
                        }
                        else
                        {
                            Menu.PressKeyToContinue();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        Menu.PressKeyToContinue();
                    }
                } while (subMenuAnswer != 'Y');
            } while (subMenuAnswer == 'Y');
        }

        internal static int GetIntOption()
        {
            var option = Console.ReadLine();
            int chosenOption = option.ValidateEnteredIntNumber();
            Console.Clear();
            return chosenOption;
        }

        internal static char GetSubMenuAnswer()
        {
            Console.WriteLine("Do you want to keep tracking this item?\n\t'Y'es - 'N'o");
            var option = Convert.ToChar(Console.ReadLine());
            char answer = option.ValidateEnteredCharacter();
            if (answer == 'Y' || answer == 'N')
            {
                Menu.PressKeyToContinue();
                return answer;
            }
            else
            {
                throw new InvalidDataException("ERROR. You´ve entered non-valid data.");
            }
        }
       
        internal static void PressKeyToContinue()
        {
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal static void DisplaySuppliers(SuppliersLogic suppliersLogic)
        {
            foreach (Suppliers supplier in suppliersLogic.GetAll())
            {
                Console.WriteLine($"■Company name: {supplier.CompanyName}   ■Contact name: {supplier.ContactName}\n" +
                                  $"■Address: {supplier.Address} ■City: {supplier.City} ■Phone: {supplier.Phone}\n");
            }
            Menu.PressKeyToContinue();
        }

        internal static char GetMenuAnswer()
        {
            char auxAnswer = 'Y';
            char answer = 'Y';
            do
            {
                Console.WriteLine("Do you want to keep running the app?\n\t'Y'es - 'N'o");
                try
                {
                    var option = Convert.ToChar(Console.ReadLine());
                    answer = option.ValidateEnteredCharacter();
                    if (answer == 'Y' || answer == 'N')
                    {
                        answer = option;
                        auxAnswer = 'Y';
                    }
                    else
                    {
                        auxAnswer = 'N';
                        throw new InvalidDataException("ERROR. You´ve entered non-valid data.");
                    }
                }
                catch (Exception ex)
                {
                    auxAnswer = 'N';
                    Console.WriteLine($"{ex.Message}");
                }
                Menu.PressKeyToContinue();
            } while (auxAnswer != 'Y');
            return answer; 
        }
    }
}