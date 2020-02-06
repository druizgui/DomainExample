// -----------------------------------------------------------------
// <copyright>Copyright (C) 2020, David Ruiz.</copyright>
// Licensed under the Apache License, Version 2.0.
// You may not use this file except in compliance with the License:
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Software is distributed on an "AS IS", WITHOUT WARRANTIES
// OR CONDITIONS OF ANY KIND, either express or implied.
// -----------------------------------------------------------------

namespace AdventureWorks.Dom
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("ShoppingCartItem", Schema = "Sales")]
    public partial class ShoppingCartItem
    {
        [Key] [Column("ShoppingCartItemID")] public int ShoppingCartItemId { get; set; }

        [Required]
        [Column("ShoppingCartID")]
        [StringLength(50)]
        public string ShoppingCartId { get; set; }

        public int Quantity { get; set; }

        [Column("ProductID")] public int ProductId { get; set; }

        [Column(TypeName = "datetime")] public DateTime DateCreated { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ShoppingCartItem")]
        public virtual Product Product { get; set; }
    }
}