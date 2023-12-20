using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplikacijaWEB.Models;

namespace AplikacijaWEB.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable <MembershipType> MembershipType { get; set; }

        public Customers Customer { get; set; }
    }
}