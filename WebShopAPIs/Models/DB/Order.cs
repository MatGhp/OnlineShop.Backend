using System;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebShopAPIs.Models.DB
{
    public class Order : BaseIdentity
    {
        
        [Required]
        public DateTime OrderDate{ get; set; }

        public IList<OrderItem> OrderItems{ get; set; }

        public Guid UserId { get; set; }
        [Required]
        public User User { get; set; }


    }
}