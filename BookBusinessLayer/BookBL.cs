using BookDataAcessLayer;
using Booksdatatransferobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBusinessLayer
{
   public class BookBL
    {
        BookDAL bookDalObj;

        public BookBL()
        {
            bookDalObj = new BookDAL();
        }

       /* public List<BookDTO> DisplayReviewFortheBook(string title)
        {
            BookDAL bObj = new BookDAL();
           
            return bObj.DisplayReviewFortheBook("");
        }
        public double AverageOfRatings(string title)
        {
            try
            {
                BookDAL avgObj = new BookDAL();
                return avgObj.AverageOfRatings(title);
            }
            catch (Exception ex)
            {

                return -99;
            }
        } */
        public List<BookDTO> Fetch()
        {
            return bookDalObj.Fetch();
        }
    }
}
