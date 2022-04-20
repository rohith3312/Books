using AdventureworkDAL;
using AdvworksBL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureworksUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dispaly Product Details");
            AdvWorksBL blObj = new AdvWorksBL();
            List<Product> prods = blObj.fetchProducts();
            foreach (var item in prods)
            {
                Console.WriteLine(item.ProductID + " | " + item.Name + " | " + item.ProductNumber + " | " + item.ListPrice);
                Console.WriteLine();

            }
        }
    }
}
