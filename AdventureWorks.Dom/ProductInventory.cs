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

    [Table("ProductInventory", Schema = "Production")]
    public partial class ProductInventory
    {
        [Key] [Column("ProductID")] public int ProductId { get; set; }

        [Key] [Column("LocationID")] public short LocationId { get; set; }

        [Required] [StringLength(10)] public string Shelf { get; set; }

        public byte Bin { get; set; }
        public short Quantity { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty("ProductInventory")]
        public virtual Location Location { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductInventory")]
        public virtual Product Product { get; set; }
    }
}