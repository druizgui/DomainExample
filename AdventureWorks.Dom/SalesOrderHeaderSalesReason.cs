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

    [Table("SalesOrderHeaderSalesReason", Schema = "Sales")]
    public partial class SalesOrderHeaderSalesReason
    {
        [Key] [Column("SalesOrderID")] public int SalesOrderId { get; set; }

        [Key] [Column("SalesReasonID")] public int SalesReasonId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(SalesOrderId))]
        [InverseProperty(nameof(SalesOrderHeader.SalesOrderHeaderSalesReason))]
        public virtual SalesOrderHeader SalesOrder { get; set; }

        [ForeignKey(nameof(SalesReasonId))]
        [InverseProperty("SalesOrderHeaderSalesReason")]
        public virtual SalesReason SalesReason { get; set; }
    }
}