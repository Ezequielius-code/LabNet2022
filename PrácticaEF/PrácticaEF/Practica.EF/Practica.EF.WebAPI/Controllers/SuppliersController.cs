using Practica.EF.Entities;
using Practica.EF.Services;
using Practica.EF.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Practica.EF.WebAPI.Controllers
{
	[EnableCors(origins: "*", headers:"*", methods:"*")]
    public class SuppliersController : ApiController
    {
		private SuppliersServices _suppliersServices;

		public SuppliersServices SuppliersServices
		{
			get 
			{
				if (_suppliersServices == null)
				{
					_suppliersServices = new SuppliersServices();
				}
				return _suppliersServices;
			}			
		}

		// GET: api/Suppliers
		[HttpGet]
		public IHttpActionResult GetSuppliers()
		{
			try
			{
				var listOfSuppliers = this.SuppliersServices.GetAll();
				List<SupplierViewModel> suppliers = listOfSuppliers.Select(s => new SupplierViewModel
				{
					SupplierId = s.SupplierID,
					CompanyName = s.CompanyName,
					City = s.City,
					Country = s.Country,
					Phone = s.Phone,
					ContactName = s.ContactName
				}).ToList();
    
				return Ok(suppliers);
			}
			catch (Exception ex)
			{
				return Content(HttpStatusCode.BadRequest, ex.Message);
			}
		}

		// GET: api/Suppliers/{id}
		[HttpGet]
		public IHttpActionResult GetSupplierById(int id)
		{
			try
			{
				var supplier = this.SuppliersServices.GetSupplierById(id);
				if (supplier == null)
				{
					throw new Exception();
				}
				SupplierViewModel supplierViewModel = new SupplierViewModel
				{
					SupplierId = supplier.SupplierID,
					CompanyName = supplier.CompanyName,
					City = supplier.City,
					Country = supplier.Country,
					Phone = supplier.Phone,
					ContactName = supplier.ContactName
				};
				return Ok(supplierViewModel);
			}
			catch (Exception ex)
			{
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
		}

		//POST: api/Suppliers
		[HttpPost]
		public IHttpActionResult AddSupplier([FromBody] SupplierViewModel supplierViewModel)
		{
			try
			{
				Suppliers supplier = new Suppliers
				{
					CompanyName = supplierViewModel.CompanyName,
					City = supplierViewModel.City,
					Country = supplierViewModel.Country,
					Phone = supplierViewModel.Phone,
					ContactName = supplierViewModel.ContactName
				};
				this.SuppliersServices.AddSupplier(supplier);
				return Content(HttpStatusCode.Created, supplier);
			}
			catch (Exception ex)
			{
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
		}

		//PUT: api/Suppliers
		[HttpPut]
		public IHttpActionResult UpdateSupplier([FromBody] SupplierViewModel supplierViewModel)
		{
            try
            {
                Suppliers supplier = new Suppliers
                {
					SupplierID = supplierViewModel.SupplierId,
                    CompanyName = supplierViewModel.CompanyName,
                    City = supplierViewModel.City,
                    Country = supplierViewModel.Country,
                    Phone = supplierViewModel.Phone,
                    ContactName = supplierViewModel.ContactName
                };
                this.SuppliersServices.UpdateSupplier(supplier);
                return Content(HttpStatusCode.Created, supplier);
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }

		//DELETE: api/Suppliers/{id}
		[HttpDelete]
		public IHttpActionResult DeleteSupplier(int id)
		{
			try
			{
				var supplier = this.SuppliersServices.GetSupplierById(id);
                if (supplier == null)
                {
                    throw new Exception();
                }
                this.SuppliersServices.DeleteSupplier(supplier.SupplierID);
                return Content(HttpStatusCode.OK, supplier);
            }
			catch (Exception ex)
			{
                return Content(HttpStatusCode.BadRequest, ex.Message);
            }
        }
	}
}
