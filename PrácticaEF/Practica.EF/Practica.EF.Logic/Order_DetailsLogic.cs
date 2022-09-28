using Practica.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica.EF.Logic
{
    public class Order_DetailsLogic : BaseLogic
    {
        public Order_DetailsLogic() : base() { }

        internal List<Order_Details> GetAll()
        {
            return _context.Order_Details.ToList();
        }

        public void Add(Order_Details ordersDetails)
        {
            _context.Order_Details.Add(ordersDetails);
            _context.SaveChanges();
        }

        internal void Delete(Order_Details orderDetails)
        {
            var detailsToUpdate = _context.Order_Details.Find(orderDetails.OrderID, orderDetails.ProductID);
            _context.Order_Details.Remove(detailsToUpdate);
            _context.SaveChanges();
        }

        internal void DetailRemoveStock(Order_Details orderDetail, byte quantity)
        {
            var detailsToUpdate = _context.Order_Details.Find(orderDetail.OrderID, orderDetail.ProductID);
            detailsToUpdate.Quantity = (short)(detailsToUpdate.Quantity - quantity);
            _context.SaveChanges();
        }

        internal void DetailAddStock(Order_Details orderDetail, byte quantity)
        {
            var detailsToUpdate = _context.Order_Details.Find(orderDetail.OrderID, orderDetail.ProductID);
            detailsToUpdate.Quantity = (short)(detailsToUpdate.Quantity + quantity);
            _context.SaveChanges();
        }
    }
}
