using MovieSpree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MovieSpree.ViewModel
{
    public class RandomViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}