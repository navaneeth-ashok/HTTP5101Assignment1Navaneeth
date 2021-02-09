using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1Navaneeth.Controllers
{
    public class NumberMachineController : ApiController
    {
        /// <summary>
        /// Method receives an integer input and calculates floor of half of id, ceil of half of id, 
        /// square of id and square root of id
        /// </summary>
        /// <param name="id">Integer ID</param>
        /// <returns>A string of of the result of all above calculation, stored as IEnumerable string type </returns>
        /// <example>
        /// GET api/NumberMachine/5
        /// </example>
        public IEnumerable<string> Get(int id)
        {
            double division_result = id / 2.0;
            int rnd_down = Convert.ToInt32(Math.Floor(division_result));
            int rnd_up = Convert.ToInt32(Math.Ceiling(division_result));
            int square = Convert.ToInt32(Math.Pow(id, 2));
            double square_root = Math.Pow(id, (1.0 / 2));
            return new string[] { "Round Down:" + Convert.ToString(rnd_down), "Round Up:" + Convert.ToString(rnd_up),
                "Square:" + Convert.ToString(square), "Square Root:" + Convert.ToString(square_root)};
        }
    }
}
