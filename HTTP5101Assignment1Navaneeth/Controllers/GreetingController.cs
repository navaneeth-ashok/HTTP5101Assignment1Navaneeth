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
        // POST api/Greeting
        /// <summary>
        /// Returns a string " Hello World!" on posting
        /// </summary>
        /// <returns>"Hello World!"</returns>
        public string Post()
        {
            string greeting = "Hello World!";
            return greeting;
        }

        // GET api/Greeting/10
        /// <summary>
        /// Receives an input and concatenates the same to the Greeting string inline
        /// </summary>
        /// <param name="id">Number of people to give the greetings to</param>
        /// <returns>A string with Greeting concatenated with the input id</returns>
        public string Get(int id)
        {
            // return "Greetings to " + id + " people!";
            // return string.Format("Greetings to {0} people", id);
            return $"Greetings to {id} people!";
        }
    }
}
