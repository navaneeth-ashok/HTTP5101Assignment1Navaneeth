using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1Navaneeth.Controllers
{
    public class AddTenController : ApiController
    {   
        // GET api/AddTen/10
        /// <summary>
        /// This method receives an input and adds 10 to it
        /// </summary>
        /// <param name="id">The input number</param>
        /// <returns>Number + 10</returns>
        public int Get(int id)
        {   
            // adding 10 to the input
            return id + 10;
        }
    }
}
