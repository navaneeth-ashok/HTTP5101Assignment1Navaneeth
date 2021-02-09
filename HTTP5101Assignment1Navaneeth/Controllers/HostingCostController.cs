using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP5101Assignment1Navaneeth.Controllers
{
    public class HostingCostController : ApiController
    {
        /* Ques: You are charging your client $5.50 / FN (fortnight = 14 days) for web hosting and maintenance,
        plus an additional 13% HST.The input { id } represents the number of days which has elapsed
        since the beginning of the hosting. Output 3 strings which describe the total hosting cost.*/

        /// <summary>
        /// Method to calculate the amount to bill the client for web hosting
        /// Logic
        /// ------------
        /// # of fortnights counted = ( floor division of the input by 14 ) + 1 
        /// value before HST = # of fortnights * rate
        /// HST  = 0.13 * value before HST(round up to two decimal)
        /// Total = HST + value before HST
        /// </summary>
        /// <param name="id">Integer id, number of days elapsed since the beginning of hosting</param>
        /// <returns>String array of strings, containing ( total_excluding tax, tax_rate, total amount)</returns>
        /// <example>
        /// GET api/HostingCost/10
        /// </example>

        public IEnumerable<string> Get (int id) 
        {
            double rate = 5.50;
            double tax_rate = 0.13; // 13%
            // # of fortnights counted = ( floor division of the input by 14 ) + 1
            int fortnights_billed = Convert.ToInt32(Math.Floor(id / 14.0)) + 1;
            // value before HST = # of fortnights * rate
            double hosting_cost_excluding_tax = Math.Round((fortnights_billed * rate), 2);
            // HST  = 0.13 * value before HST(round up to two decimal)
            double tax = Math.Round((tax_rate * hosting_cost_excluding_tax), 2);
            // Total = HST + value before HST
            double total_cost = tax + hosting_cost_excluding_tax;
            string total_excluding_tax = string.Format("{0} fortnights at $5.50/FN = ${1:.00} CAD", fortnights_billed, hosting_cost_excluding_tax);
            string tax_amount = string.Format("HST 13% = ${0:0.00} CAD", tax);
            string total_amount = string.Format("Total = ${0:.00} CAD", total_cost);
            return new string[]
            {
                total_excluding_tax,
                tax_amount,
                total_amount
            };
        }
    }
}
