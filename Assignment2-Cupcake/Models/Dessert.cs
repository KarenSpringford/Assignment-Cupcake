using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment2_Cupcake.Models
{
    public class Dessert
    {

        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Dessert() { }

        /// <summary>
        /// This constructor takes one parameter
        /// </summary>
        public Dessert(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }

    }
}