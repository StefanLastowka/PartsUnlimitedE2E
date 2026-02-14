using System;
using System.ComponentModel.DataAnnotations;

namespace PartsUnlimited.Models
{
    // My first change too be committed to git
    public class CartItem : ILineItem
    {
        // My second change
        [Key]
        public int CartItemId { get; set; }

        // My third change

        [Required]
        public string CartId { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime DateCreated { get; set; }

        public virtual Product Product { get; set; }
    }
}