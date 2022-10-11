using Practica.EF.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Practica.EF.Logic
{
    public class SuppliersLogic : BaseLogic, ICRUDLogic<Suppliers>
    {
        public SuppliersLogic() : base() { }

        public List<Suppliers> GetAll()
        {
            return _context.Suppliers.ToList();
        }

        public Suppliers GetSupplierById(int id)
        {
            var supplier = _context.Suppliers.FirstOrDefault(x => x.SupplierID == id);
            return supplier;
        }

        public void Add(Suppliers supplier)
        {
            _context.Suppliers.Add(supplier);
            _context.SaveChanges();
        }

        public void Update(Suppliers supplier)
        {
            var supplierToUpdate = _context.Suppliers.Find(supplier.SupplierID);
            supplierToUpdate.CompanyName = supplier.CompanyName;
            supplierToUpdate.City = supplier.City;
            supplierToUpdate.Country = supplier.Country;
            supplierToUpdate.Phone = supplier.Phone;
            supplierToUpdate.ContactName = supplier.ContactName;
            _context.Entry(supplierToUpdate).Property(u => u.SupplierID).IsModified = false;
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var supplierToRemove = _context.Suppliers.Find(id);
            ChangeSupplierAvailability(supplierToRemove.SupplierID);
            _context.Suppliers.Remove(supplierToRemove);
            _context.SaveChanges();
        }

        private void ChangeSupplierAvailability(int supplierId)
        {
            ProductsLogic productsLogic = new ProductsLogic();
            foreach (Products product in productsLogic.GetAll())
            {
                if (supplierId == product.SupplierID)
                {
                    productsLogic.UpdateSupplierId(product);
                }
            }
        }
    }
}