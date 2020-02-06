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

    [Table("PurchaseOrderDetail", Schema = "Purchasing")]
    public partial class PurchaseOrderDetail
    {
        [Key] [Column("PurchaseOrderID")] public int PurchaseOrderId { get; set; }

        [Key]
        [Column("PurchaseOrderDetailID")]
        public int PurchaseOrderDetailId { get; set; }

        [Column(TypeName = "datetime")] public DateTime DueDate { get; set; }

        public short OrderQty { get; set; }

        [Column("ProductID")] public int ProductId { get; set; }

        [Column(TypeName = "money")] public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")] public decimal LineTotal { get; set; }

        [Column(TypeName = "decimal(8, 2)")] public decimal ReceivedQty { get; set; }

        [Column(TypeName = "decimal(8, 2)")] public decimal RejectedQty { get; set; }

        [Column(TypeName = "decimal(9, 2)")] public decimal StockedQty { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("PurchaseOrderDetail")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(PurchaseOrderId))]
        [InverseProperty(nameof(PurchaseOrderHeader.PurchaseOrderDetail))]
        public virtual PurchaseOrderHeader PurchaseOrder { get; set; }
    }
}