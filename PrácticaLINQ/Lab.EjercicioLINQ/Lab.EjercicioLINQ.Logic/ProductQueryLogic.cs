using Lab.EjercicioLINQ.Entities;
using Lab.EjercicioLINQ.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EjercicioLINQ.Logic
{
    public class ProductQueryLogic : BaseLogic
    {
        public ProductQueryLogic() : base() { }

        public IQueryable<Products> ProductsOutOfStock()
        {
            var dbProducts = _context.Products;
            var products = from p in dbProducts
                           where p.UnitsInStock == 0
                           select p;

            return products;
        }

        public IQueryable<Products> ProductsMoreExpensiveThan3WithStock()
        {
            var dbProducts = _context.Products;
            var products = dbProducts.Where(p => p.UnitsInStock > 0)
                                     .Where(p => p.UnitPrice > 3);
            return products;
        }

        public string GetProductWithId789()
        {
            var dbProducts = _context.Products;
            try
            {
                Products productToShow = new Products();
                var product = dbProducts.Where(p => p.ProductID == 789).FirstOrDefault();
                if (product is null)
                {
                    return "Sorry, seems that the product doesn´t exist.";
                }
                return productToShow.ToString();
            }
            catch (Exception ex)
            {
                return $"Ooops... something went wrong.\n{ex.Message}";
            }
        }

        public IQueryable<Products> ProductsOrderedByName()
        {
            var dbProducts = _context.Products;
            var productsOrdered = dbProducts.OrderBy(p => p.ProductName);

            return productsOrdered;
        }

        public IQueryable<Products> ProductsOrderedByDescendingStock()
        {
            var dbProducts = _context.Products;
            var productsOrdered = from p in dbProducts
                                  orderby p.UnitsInStock descending
                                  select p;
            return productsOrdered;
        }

        public IQueryable<ProductCategory> GetProductsWithAssociatesCategories()
        {
            var dbProducts = _context.Products;
            var dbCategories = _context.Categories;
            var productCategories = from c in dbCategories
                                    join p in dbProducts
                                    on c.CategoryID equals p.CategoryID
                                    orderby c.CategoryID ascending
                                    select new ProductCategory
                                    {
                                        CategoryID = c.CategoryID,
                                        CategoryName= c.CategoryName,
                                        ProductName = p.ProductName
                                    };
            return productCategories;
        }

        public Products GetFirstProduct()
        {
            var dbProducts = _context.Products;
            var firstProduct = dbProducts.First();

            return firstProduct;
        }
    }
}
