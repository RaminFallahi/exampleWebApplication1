using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace exampleWebApplication1.Controllers
{
    public class practiceController : ApiController
    {
        /// <summary>
        /// returns a greeting
        /// </summary>
        /// <returns>Hello</returns>
        /// <example>GET: api/Week4 -> Hello
        /// </example>
        [Route("api/W3_N01379071/Greeting")]
        [HttpGet]
        public string Greeting()
        {
            return "Hello";
        }
        /// <summary>
        /// says goodbye
        /// </summary>
        /// <returns>Goodbye</returns>
        /// <example>GET: api/week4/Goodbye -> :Goodbye
        /// </example>
        [HttpGet]
        [Route("api/W3_N01379071/goodbye")]
        public string Get()
        {
            return "Goodbye";
        }
        ///<summary>
        ///determine the validity of the race car given dimensions
        ///tank must be < 60l
        ///wheel size must be between 50 and 56cm
        ///spoiler must be <20cm height
        ///</summary>
        ///<returns>The speed of car</returns>
        ///<param name="TankSize">tank size in L</param>
        ///<param name="WheelDimeter">wheel diameter in CM</param>
        ///<param name="SpoilerHeight">the height of spoiler in CM</paeam>
        ///<example>
        ///GET: api/Week4/CarCalculator/50/25/15 -> "valid"
        ///GET: api/Week4/CarCalculator/100/25/15 -> "Not valid"
        ///GET: api/Week4/CarCalculator/55/70/19 -> "Not valid"
        ///</example>
        [Route("api/W3_N01379071/{TankSize}/{WheelDiameter}/{SpoilerHeight}")]
        [HttpGet]
        public string CarCalculator(int TankSize, int WheelDimeter, int SpoilerHeight)
        {
            if (TankSize > 60) // tank is too big
            {
                return "Not Valid";
            }
            else if (WheelDimeter < 50) //Wheel are too small
            {
                return "Not Valid";
            }
            else if (WheelDimeter > 56)
            {
                return "Not Valid";
            }
            else if (SpoilerHeight > 20) // spoilet is too tall
            {
                return "Not Valid";
            }
            else
            {
                return "Valid";
            }
        }

        /// <summary>
        /// Returns if the weeding is on the budget
        /// 
        /// cost of wedding is number of the guests * venue size
        /// </summary>
        /// <param name="numGuests">The number of the Guests in the wedding</param>
        /// <param name="VenueSize">The venue size in square feet</param>
        /// <param nmae="Budget">the budget in CAD</param>
        /// <returns>if the wedding is under or over the budger</returns>
        /// <example>
        /// GET: api/week4/weedingCalculator/10/2000/25000 -> "weeding is under the budger"
        /// GET: api/week4/weedingCalculator/10/2000/25000 -> "weeding is under the budger"
        [Route("api/week4/weedingCalculator")]
        [HttpGet]
        public string weedingCalculator(int numGuests, int VenueSize, int Budget)
        {
            int WeddingCost = numGuests * VenueSize;
            if (WeddingCost > Budget)
            {
                return "Wedding is over budget";
            }
            else if (WeddingCost == Budget)
            {
                return "Wedding is on the budget";
            }
            else
            {
                return "Wedding is under budget";
            }
        }
    }
}
