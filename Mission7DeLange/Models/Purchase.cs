﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission7DeLange.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please Enter a name.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Enter the first address line.")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage = "Please Enter a city.")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please Enter a state")]
        public string State { get; set; }
        public string Zip { get; set; }

        [Required(ErrorMessage = "Please Enter a country.")]
        public string Country { get; set; }
        [BindNever]
        public bool PurchaseShipped { get; set; }

    }
}
