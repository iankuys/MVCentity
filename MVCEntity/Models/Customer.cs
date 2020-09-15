using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCEntity.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public int EmailAddress { get; set; }

        public string Password { get; set; }
    }
}