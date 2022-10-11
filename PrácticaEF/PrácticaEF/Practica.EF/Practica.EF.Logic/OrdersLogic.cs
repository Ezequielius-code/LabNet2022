using Practica.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica.EF.Logic
{
    public class OrdersLogic : BaseLogic, ICRUDLogic<Orders>
    {
        public OrdersLogic() : base() { }

        public List<Orders> GetAll()
        {
            return _context.Orders.ToList();
        }

        public Orders GetOrderById(int orderId)
        {
            foreach (Orders order in _context.Orders.ToList())
            {
                if (orderId == order.OrderID)
                {
                    return order;
                }
            }
            return null;
        }

        public void Add(Orders order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Orders order)
        {
            var orderToUpdate = _context.Orders.Find(order.OrderID);
            orderToUpdate.ShipVia = order.ShipVia;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderToRemove = _context.Orders.Find(id);
            _context.Orders.Remove(orderToRemove);
            _context.SaveChanges();
        }

        public void ToDelete(int orderId, OrdersLogic ordersLogic, Order_DetailsLogic orderDetailsLogic, ProductsLogic productsLogic)
        {
            var orderToRemove = _context.Orders.Find(orderId);
            foreach (Order_Details orderDetail in orderDetailsLogic.GetAll())
            {
                if (orderId == orderDetail.OrderID)
                {
                    foreach (Products product in productsLogic.GetAll())
                    {
                        if (product.ProductID == orderDetail.ProductID)
                        {
                            productsLogic.AddStock(product, (byte)orderDetail.Quantity);
                        }
                    }
                    orderDetailsLogic.Delete(orderDetail);
                }
            }
            _context.Orders.Remove(orderToRemove);
            _context.SaveChanges();
        }

        public int GetOrderQuantity(Orders order, Order_DetailsLogic orderDetailsLogic)
        {
            int quantity = 0;
            foreach (Order_Details orderDetail in orderDetailsLogic.GetAll())
            {
                if (order.OrderID == orderDetail.OrderID)
                {
                    quantity = orderDetail.Quantity;
                    return quantity;
                }
            }
            return quantity;
        }

        public byte GetProductIdInOrder(Orders order, Order_DetailsLogic orderDetailsLogic, ProductsLogic productsLogic)
        {
            foreach (Order_Details orderDetail  in orderDetailsLogic.GetAll())
            {
                if (order.OrderID == orderDetail.OrderID)
                {
                    foreach (Products product in productsLogic.GetAll())
                    {
                        if (orderDetail.ProductID == product.ProductID)
                        {
                            return (byte)product.ProductID;
                        }
                    }
                }
            }
            return 0;
        }

        public void RemoveOrderStock(Orders order, byte quantity, Order_DetailsLogic orderDetailsLogic, ProductsLogic productsLogic)
        {
            foreach (Order_Details orderDetail in orderDetailsLogic.GetAll())
            {
                if (order.OrderID == orderDetail.OrderID)
                {
                    orderDetailsLogic.DetailRemoveStock(orderDetail, quantity);
                    foreach (Products product in productsLogic.GetAll())
                    {
                        if (orderDetail.ProductID == product.ProductID)
                        {
                            productsLogic.AddStock(product, quantity);
                        }
                    }
                }
            }
        }

        public void AddOrderStock(Orders order, byte quantity, Order_DetailsLogic orderDetailsLogic, ProductsLogic productsLogic)
        {
            foreach (Order_Details orderDetail in orderDetailsLogic.GetAll())
            {
                if (order.OrderID == orderDetail.OrderID)
                {
                    orderDetailsLogic.DetailAddStock(orderDetail, quantity);
                    foreach (Products product in productsLogic.GetAll())
                    {
                        if (orderDetail.ProductID == product.ProductID)
                        {
                            productsLogic.RemoveStock(product, quantity);
                        }
                    }
                }
            }
        }
    }
}