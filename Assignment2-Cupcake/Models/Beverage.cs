using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_Cupcake.Models
{
    public class Beverage
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Beverage() { }

        /// <summary>
        /// This constructor takes one parameter
        /// </summary>
        public Beverage(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}