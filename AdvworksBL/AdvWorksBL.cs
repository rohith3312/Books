using AdventureworkDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvworksBL
{
    public class AdvWorksBL
    {

    
        public List<Product> fetchProducts()
        {
            try
            {
                AdvworksDAL advObj = new AdvworksDAL();
                return advObj.fetchProducts();

            }
            catch (Exception ex)
            {

                return null;
            }
        }
    }
}
