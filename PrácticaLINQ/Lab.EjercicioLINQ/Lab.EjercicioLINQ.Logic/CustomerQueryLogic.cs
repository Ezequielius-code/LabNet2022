using Lab.EjercicioLINQ.Commons;
using Lab.EjercicioLINQ.Entities;
using Lab.EjercicioLINQ.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Lab.EjercicioLINQ.Logic
{
    public class CustomerQueryLogic : BaseLogic
    {
        public CustomerQueryLogic() : base() { }

        public IQueryable<string> GetCustomersId()
        {
            var dbCustomers = _context.Customers;
            var getCustomersId = dbCustomers.Select(c => c.CustomerID);
            return getCustomersId;
        }

        public string GetCustomerById(string customerId)      
        {
            var dbCustomers = _context.Customers;
            string failureMessage = "Sorry, seems that the entered Id doesn´t exist.";
            if (customerId.IsValidCustomer())
            {
                Customers customerToShow = new Customers();
                var customer = dbCustomers.Where(c => c.CustomerID == customerId);
                foreach (var item in customer)
                {
                    customerToShow.CustomerID = item.CustomerID;
                    customerToShow.CompanyName = item.CompanyName;
                    customerToShow.Address = item.Address;
                    customerToShow.City = item.City;
                    customerToShow.Country = item.Country;
                    customerToShow.PostalCode = item.PostalCode;
                    customerToShow.Phone = item.Phone;
                    customerToShow.Fax = item.Fax;
                    customerToShow.ContactName = item.ContactName;
                }
                return customerToShow.ToString();
            }
            return failureMessage;
        }

        public IQueryable<Customers> CustomersInWA()
        {
            var dbCustomers = _context.Customers;
            var customers = from c in dbCustomers
                            where c.Region == "WA"
                            select c;
            return customers;
        }

        public IEnumerable<string> CustomersNamesUpLow()
        {
            var dbCustomers = _context.Customers;
            var customers = from c in dbCustomers
                            select c.CompanyName;

            return customers.ToList();
        }

        public IQueryable<CustomerOrder> CustomersFromWAWithOrders()
        {
            var dbCustomers = _context.Customers;
            var dbOrders = _context.Orders;
            var customers = dbOrders.Join(
                            dbCustomers,
                            o => o.CustomerID,
                            c => c.CustomerID,
                            (o, c) => new CustomerOrder
                            {
                                CompanyName = c.CompanyName,
                                Region = c.Region,
                                OrderID = o.OrderID,
                                OrderDate = o.OrderDate
                            }).
                            Where(OandC => OandC.Region == "WA").
                            Where(OandC => OandC.OrderDate > new DateTime(1997, 01, 01));
            return customers;
        }

        public IQueryable<Customers> Top3CustomersFromWA()
        {
            var dbCustomers = _context.Customers;
            var top3Customers = (from c in dbCustomers
                                where c.Region == "WA"
                                select c).Take(3);
            return top3Customers;
        }

        public IQueryable<CustomerOrder> GetCustomersWithAssociateOrders()
        {
            var dbCustomers = _context.Customers;
            var dbOrders = _context.Orders;
            var customersWithOrders = from c in dbCustomers
                                      join o in dbOrders
                                      on c.CustomerID equals o.CustomerID
                                      group c by new
                                      {
                                          c.CustomerID,
                                          c.CompanyName
                                      }
                                      into co
                                      select new CustomerOrder
                                      {
                                          CustomerID = co.Key.CustomerID,
                                          CompanyName = co.Key.CompanyName,
                                          NumberOfOrders = co.Count()
                                      };
            return customersWithOrders;
        }
    }
}
