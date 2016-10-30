using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace WebShopAPIs.Models.DB
{
    public class Product : BaseIdentity
    {

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Color { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        [MaxLength(400)]
        public string ImageUrl { get; set; }


        [MaxLength(400)]
        public string Description { get; set; }

        
        [MaxLength(100)]
        public string Details { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}