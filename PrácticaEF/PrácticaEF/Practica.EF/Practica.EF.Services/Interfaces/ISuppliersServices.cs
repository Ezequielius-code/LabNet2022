using Practica.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Services.Interfaces
{
    internal interface ISuppliersServices
    {
        List<Suppliers> GetAll();
        Suppliers GetSupplierById(int id);
        void AddSupplier(Suppliers supplier);
        void UpdateSupplier(Suppliers supplier);
        void DeleteSupplier(int id);
    }
}
