using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEntity.Models
{
    public class CustomerInfo
    {
        [Key]
        public int CustomerId { get; set; }
        public Customer customer { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set;}

        public string Address { get; set; }

        public DateTime birthdate { get; set; }

    }
}