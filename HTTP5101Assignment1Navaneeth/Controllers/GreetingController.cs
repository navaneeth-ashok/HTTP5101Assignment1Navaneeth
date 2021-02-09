using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1Navaneeth.Controllers
{
    public class GreetingController : ApiController
    {   
        /// <summary>
        /// Returns a string " Hello World!" on posting
        /// </summary>
        /// <returns>"Hello World!"</returns>
        /// <example>
        /// POST api/Greeting/
        /// </example>
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        /// <summary>
        /// Receives an input and concatenates the same to the Greeting string inline
        /// </summary>
        /// <param name="id">Number of people to give the greetings to</param>
        /// <returns>A string with Greeting concatenated with the input id</returns>
        /// <example>
        /// GET api/Greeting/10
        /// </example>
        public string Get(int id)
        {
            // return "Greetings to " + id + " people!";
            // return string.Format("Greetings to {0} people", id);
            return $"Greetings to {id} people!";
        }
    }
}
