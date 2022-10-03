using Lab.EjercicioLINQ.Data;
using System.Linq;

namespace Lab.EjercicioLINQ.Commons
{
    public static class EntitiesValidator
    {
        public static bool IsValidCustomer(this string customerId)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                if (db.Customers.Any(c => c.CustomerID == customerId.Trim().ToUpper()))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
