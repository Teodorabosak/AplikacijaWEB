using AplikacijaWEB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AplikacijaWEB.ViewModels
{
    public class RandomMovieView
    {
        public Movie Movie { get; set; }
        public List<Customers> Customers { get; set; }
    }
}