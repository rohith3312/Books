using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booksdatatransferobject
{
    public class BookDTO
    {
        public string Review;
        private BookDTO bookDTO;

        public BookDTO()
        {
        }

        public BookDTO(BookDTO bookDTO)
        {
            this.bookDTO = bookDTO;
        }

        public int book_isbn { get; set; }
        public string Title { get; set; }
        public string author { get; set; }
        public int rating { get; set; }
       
        





    }
}