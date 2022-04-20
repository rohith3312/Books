using BookBusinessLayer;
using Booksdatatransferobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookBL ObjBL=new BookBL();
            Console.WriteLine("starts");
         

            List<BookDTO> df = ObjBL.DisplayReviewFortheBook("smg");
            foreach (BookDTO d in df)
            {
                Console.WriteLine(d.book_isbn);
                Console.WriteLine(d.Title);
                Console.WriteLine(d.Review);
            }
             Console.WriteLine("Average  ratings of book");

            BookBL averageObj = new BookBL();
            double average = averageObj.AverageOfRatings("The Little Prince");
            Console.WriteLine(average);

        }
    }
    }
