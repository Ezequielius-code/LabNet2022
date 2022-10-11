using Practica.EF.Entities;
using Practica.EF.Logic;
using Practica.EF.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica.EF.Services
{
    public class SuppliersServices : ISuppliersServices
    {
        private SuppliersLogic _suppliersLogic;
        
        public SuppliersLogic SuppliersLogic
        {
            get
            {
                if (_suppliersLogic == null)
                {
                    _suppliersLogic = new SuppliersLogic();
                }
                return _suppliersLogic;
            }
        }

        public List<Suppliers> GetAll()
        {
            try
            {
                return this.SuppliersLogic.GetAll();
            }
            catch (Exception)
            {
                throw new Exception("Action couldn´t be done.");
            }
        }

        public Suppliers GetSupplierById(int id)
        {
            try
            {
                return this.SuppliersLogic.GetSupplierById(id);
            }
            catch (Exception)
            {
                throw new Exception("Action couldn´t be done.");
            }
        }
        public void AddSupplier(Suppliers supplier)
        {
            try
            {
                this.SuppliersLogic.Add(supplier);
            }
            catch (Exception)
            {
                throw new Exception("Action couldn´t be done.");
            }
        }

        public void UpdateSupplier(Suppliers supplier)
        {
            try
            {
                this.SuppliersLogic.Update(supplier);
            }
            catch (Exception)
            {
                throw new Exception("Action couldn´t be done.");
            }
        }

        public void DeleteSupplier(int id)
        {
            try
            {
                this.SuppliersLogic.Delete(id);
            }
            catch (Exception)
            {
                throw new Exception("Action couldn´t be done.");
            }
        }
    }
}
