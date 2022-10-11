using Microsoft.Ajax.Utilities;
using Practica.EF.Entities;
using Practica.EF.Logic;
using Practica.EF.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace Practica.EF.MVC.Controllers
{
    public class SuppliersController : Controller
    {
        SuppliersLogic suppliersLogic = new SuppliersLogic();

        // GET: Suppliers
        public ActionResult Index()
        {
            List<Suppliers> suppliers = suppliersLogic.GetAll();
            List<SuppliersViewModel> suppliersView = suppliers.Select(s => new SuppliersViewModel
            {
                SupplierId = s.SupplierID,
                CompanyName = s.CompanyName,
                City = s.City,
                Country = s.Country,
                Phone = s.Phone,
                ContactName = s.ContactName,
            }).ToList();
            return View(suppliersView);
        }

        public ActionResult Insert()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Insert(SuppliersViewModel suppliersView)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(suppliersView);
                }
                var supplierEntity = new Suppliers
                {
                    SupplierID = suppliersView.SupplierId,
                    CompanyName = suppliersView.CompanyName,
                    City = suppliersView.City,
                    Country = suppliersView.Country,
                    Phone = suppliersView.Phone,
                    ContactName = suppliersView.ContactName
                };

                suppliersLogic.Add(supplierEntity);
                return RedirectToAction("Index");   
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Update(int id)
        {
            List<Suppliers> suppliers = suppliersLogic.GetAll();
            var suppliersView = suppliers.Where(s => s.SupplierID == id).FirstOrDefault();
            SuppliersViewModel supplierModel = new SuppliersViewModel()
            {
                SupplierId = suppliersView.SupplierID,
                CompanyName = suppliersView.CompanyName,
                City = suppliersView.City,
                Country = suppliersView.Country,
                Phone = suppliersView.Phone,
                ContactName = suppliersView.ContactName
            };

            return View(supplierModel);
        }

        [HttpPost]
        public ActionResult Update(SuppliersViewModel suppliersView)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(suppliersView);
                }
                List<Suppliers> suppliersList = suppliersLogic.GetAll();
                var supplierListed = suppliersList.Where(s => s.SupplierID == suppliersView.SupplierId).FirstOrDefault();
                Suppliers supplierUpdated = new Suppliers
                {
                    SupplierID = suppliersView.SupplierId,
                    CompanyName = suppliersView.CompanyName,
                    City = suppliersView.City,
                    Country = suppliersView.Country,
                    Phone = suppliersView.Phone,
                    ContactName = suppliersView.ContactName
                };
                suppliersLogic.Update(supplierUpdated);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            suppliersLogic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}