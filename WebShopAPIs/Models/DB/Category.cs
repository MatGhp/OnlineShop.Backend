using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebShopAPIs.Models.DB
{
    public class Category : BaseIdentity
    {
        [Required]
        [MaxLength(150)]
        public string Name { get; set; }
        public IList<Product> Products { get; set; }
    }

}
