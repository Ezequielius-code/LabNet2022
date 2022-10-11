using Practica.EF.Entities;
using Practica.EF.Logic;

namespace Practica.EF.Commons
{
    public static class EntitiesValidator
    {
        public static bool IsValidProduct(ProductsLogic productsLogic, byte productId)
        {
            foreach (Products product in productsLogic.GetAll())
            {
                if (productId == product.ProductID && product.UnitsInStock > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsValidQuantity(ProductsLogic productsLogic, byte productId, byte quantityRequested)
        {
            foreach (Products product in productsLogic.GetAll())
            {
                if (productId == product.ProductID && quantityRequested <= product.UnitsInStock && quantityRequested > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsValidShipVia(int shipVia)
        {
            if (shipVia > 0 && shipVia <=3)
            {
                return true;
            }
            return false;
        }

        public static bool IsValidOrderId(OrdersLogic ordersLogic, int orderId)
        {
            foreach (Orders order in ordersLogic.GetAll())
            {
                if (orderId == order.OrderID)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
