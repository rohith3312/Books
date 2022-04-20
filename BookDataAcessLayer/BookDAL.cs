
using Booksdatatransferobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDataAcessLayer

{
    public class BookDAL
    {
        BookRecomendationEntities bookContextObj;

        public BookDAL()
        {
            bookContextObj = new BookRecomendationEntities();
        }

     /*   public List<BookDTO> DisplayReviewFortheBook(string title)

        {
            try
            {
                var lstBookReview = (from r in bookContextObj.Reviews
                                     join b in bookContextObj.Books on r.book_isbn equals b.book_isbn
                                     where b.title.Contains(title)

                                     select new
                                     {
                                         b.book_isbn,
                                         b.title,
                                         r.rating,
                                         r.review1
                                     }).ToList();

                List<BookDTO> result = new List<BookDTO>();

                foreach (var item in lstBookReview)
                {
                    result.Add(new BookDTO()
                    {
                        Title = item.title,
                        book_isbn = item.book_isbn,
                        rating = item.rating,
                        Review = item.review1

                    });
                }
                return result;

            }
            catch (Exception)
            {

                throw;
            }

        }
        public double AverageOfRatings(string title)
        {
            try
            {
                var AvgRatings = (from b in bookContextObj.Books
                                  join r in bookContextObj.Reviews
                                  on b.book_isbn equals r.book_isbn


                                  select r.rating).Average();

                return AvgRatings;
            }

            catch (Exception)
            {

                throw;
            }
        } */

        public List<BookDTO> Fetch()
        {
            var c = (from x in bookContextObj.Books
                     select new { x.book_isbn, x.title }).ToList();
            List<BookDTO> lstBookReview = new List<BookDTO>();
            foreach (var item in c)
            {
                lstBookReview.Add(new BookDTO()
                {
                    book_isbn = item.book_isbn,
                    Title = item.title,
                });
            }
            return lstBookReview;
        }
    }
}