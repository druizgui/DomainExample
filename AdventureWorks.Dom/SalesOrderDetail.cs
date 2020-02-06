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

    [Table("SalesOrderDetail", Schema = "Sales")]
    public partial class SalesOrderDetail
    {
        [Key] [Column("SalesOrderID")] public int SalesOrderId { get; set; }

        [Key] [Column("SalesOrderDetailID")] public int SalesOrderDetailId { get; set; }

        [StringLength(25)] public string CarrierTrackingNumber { get; set; }

        public short OrderQty { get; set; }

        [Column("ProductID")] public int ProductId { get; set; }

        [Column("SpecialOfferID")] public int SpecialOfferId { get; set; }

        [Column(TypeName = "money")] public decimal UnitPrice { get; set; }

        [Column(TypeName = "money")] public decimal UnitPriceDiscount { get; set; }

        [Column(TypeName = "numeric(38, 6)")] public decimal LineTotal { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty(nameof(SalesOrderHeader.SalesOrderDetail))]
        public virtual SalesOrderHeader SalesOrder { get; set; }

        [ForeignKey("SpecialOfferId,ProductId")]
        [InverseProperty("SalesOrderDetail")]
        public virtual SpecialOfferProduct SpecialOfferProduct { get; set; }
    }
}