﻿using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebShopAPIs.Models.DB {
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }

        [Required]
        public byte Level { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public IList<Order> Orders { get; set; }
    }

}
