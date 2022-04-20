using BookBusinessLayer;
using Booksdatatransferobject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BookReviewAPI.Controllers
{
    public class bookController : ApiController
    {
        BookBL BLobj;
        public bookController()
        {
            BLobj = new BookBL();
        }
        [HttpGet]
        public HttpResponseMessage Fetch()
        {
            try
            {
                List<BookDTO> lst = BLobj.Fetch();
                if (lst.Count > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, lst);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NoContent);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
