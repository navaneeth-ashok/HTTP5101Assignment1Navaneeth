using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1Navaneeth.Controllers
{
    public class SquareController : ApiController
    {

        /// <summary>
        /// This method received an input and returns the square of the same
        /// </summary>
        /// <param name="id">The input in integer type</param>
        /// <returns>Sqaure of the input in integer type</returns>
        /// <example>
        /// GET api/Square/10
        /// </example>
        public int Get(int id)
        {   
            // alternate way of doing the same : id * id
            // using Math function for flexibility
            return Convert.ToInt32(Math.Pow(id, 2));
        }
    }
}
