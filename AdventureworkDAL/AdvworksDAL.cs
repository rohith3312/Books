using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureworkDAL
{
    public class AdvworksDAL
    {
        AdventureWorks2012Entities advContextObj;

        public AdvworksDAL()
        {
            advContextObj = new AdventureWorks2012Entities();
        }

        public List<Product> fetchProducts()
        {
            try
            {
                var lstProducts = (from p in advContextObj.Products
                                   select new
                                   {
                                       p.ProductID,
                                       p.Name,
                                       p.ListPrice,
                                       p.ProductNumber
                                   }).ToList();

                List<Product> products = new List<Product>();
                foreach (var items in lstProducts)
                {
                    products.Add(new Product()
                    {
                        ProductID = items.ProductID,
                        Name = items.Name,
                        ListPrice = items.ListPrice,
                        ProductNumber = items.ProductNumber

                    });
                }
                return products;
            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
  
