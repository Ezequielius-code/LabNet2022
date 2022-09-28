using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Practica.EF.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public ProductsLogic() : base() { }

        public List<Products> GetAll()
        {
            return _context.Products.ToList();
        }

        public void UpdateOrderRequested(Order_Details orderDetails)
        {
            var productToUpdate = _context.Products.Find(orderDetails.ProductID);
            productToUpdate.UnitsOnOrder = orderDetails.Quantity;
            productToUpdate.UnitsInStock = Convert.ToInt16(productToUpdate.UnitsInStock - orderDetails.Quantity);
            _context.SaveChanges();
        }

        internal void UpdateSupplierId(Products product)
        {
            var productToUpdate = _context.Products.Find(product.ProductID);
            productToUpdate.SupplierID = null;
            _context.SaveChanges();
        }

        public void AddStock(Products product, byte quantity)
        {
            var productToUpdate = _context.Products.Find(product.ProductID);
            productToUpdate.UnitsInStock = (short)(product.UnitsInStock + quantity);
            _context.SaveChanges();
        }

        public void RemoveStock(Products product, byte quantity)
        {
            var productToUpdate = _context.Products.Find(product.ProductID);
            if (productToUpdate.UnitsInStock < quantity)
            {
                productToUpdate.UnitsOnOrder = quantity;
            }
            else
            {
                productToUpdate.UnitsInStock = (short)(productToUpdate.UnitsInStock - quantity);
            }
            _context.SaveChanges();
        }
    }
}
