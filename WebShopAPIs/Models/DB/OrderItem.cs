using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace WebShopAPIs.Models.DB
{
    public class OrderItem : BaseIdentity
    {
        [Required]
        public int Quantity { get; set; }
        [Required]
        public int Price { get; set; }

        public int OrderId { get; set; }
        [Required]
        public Order Order { get; set; }

        public int ProductId { get; set; }
        [Required]
        public Product Product { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}