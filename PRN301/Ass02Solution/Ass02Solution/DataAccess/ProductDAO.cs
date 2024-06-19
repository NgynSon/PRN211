using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    internal class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();

        public ProductDAO()
        {

        }

        //----------------------------------------------------
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<Product> SearchProducts(string searchBy, string keyword)
        {
            using (FStoreContext dbContext = new FStoreContext())
            {

                switch (searchBy)
                {
                    case "Product Name":
                        return dbContext.Products.Where(p => p.ProductName.Contains(keyword)).ToList();
                        break;
                    case "Product ID":
                        return dbContext.Products.Where(p => p.ProductId == int.Parse(keyword)).ToList();
                        break;
                    case "Unit In Stock":
                        return dbContext.Products.Where(p => p.UnitsInStock == int.Parse(keyword)).ToList();
                        break;
                    case "Unit Price":
                        return dbContext.Products.Where(p => p.UnitPrice == decimal.Parse(keyword)).ToList();
                        break;
                    default:
                        return null;
                        break;
                }
            }
        }

        //--------------------------------------

        public void AddProduct(Product product)
        {
            try
            {
                FStoreContext productDBContext = new FStoreContext();
                productDBContext.Products.Add(product);
                productDBContext.SaveChanges();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void UpdateProduct(Product product)
        {
            try
            {
                FStoreContext productDBContext = new FStoreContext();
                productDBContext.Entry<Product>(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                productDBContext.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void DeleteProduct(int productId)
        {
            try
            {
                FStoreContext productDBContext = new FStoreContext();

                var product = productDBContext.Products.SingleOrDefault(products => products.ProductId == productId);
                if (product != null)
                {
                    productDBContext.Remove(product);
                    productDBContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public IEnumerable<Product> GetProductList()
        {
            FStoreContext context = new FStoreContext();
            var producs = context.Products.ToList();
            return producs;
        }


    }
}
