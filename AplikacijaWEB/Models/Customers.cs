using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AplikacijaWEB.Models
{
    public class Customers
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]

        public string Name { get; set; }

        public bool isSubscribedToNewsletter { get; set; }

        public DateTime? Birthdate { get; set; }

        public MembershipType MembershipType { get; set; }


        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
    }
}