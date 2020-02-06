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
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("PurchaseOrderHeader", Schema = "Purchasing")]
    public partial class PurchaseOrderHeader
    {
        [Key] [Column("PurchaseOrderID")] public int PurchaseOrderId { get; set; }

        public byte RevisionNumber { get; set; }
        public byte Status { get; set; }

        [Column("EmployeeID")] public int EmployeeId { get; set; }

        [Column("VendorID")] public int VendorId { get; set; }

        [Column("ShipMethodID")] public int ShipMethodId { get; set; }

        [Column(TypeName = "datetime")] public DateTime OrderDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? ShipDate { get; set; }

        [Column(TypeName = "money")] public decimal SubTotal { get; set; }

        [Column(TypeName = "money")] public decimal TaxAmt { get; set; }

        [Column(TypeName = "money")] public decimal Freight { get; set; }

        [Column(TypeName = "money")] public decimal TotalDue { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty("PurchaseOrderHeader")]
        public virtual Employee Employee { get; set; }

        [ForeignKey(nameof(ShipMethodId))]
        [InverseProperty("PurchaseOrderHeader")]
        public virtual ShipMethod ShipMethod { get; set; }

        [ForeignKey(nameof(VendorId))]
        [InverseProperty("PurchaseOrderHeader")]
        public virtual Vendor Vendor { get; set; }

        [InverseProperty("PurchaseOrder")] public virtual ICollection<PurchaseOrderDetail> PurchaseOrderDetail { get; set; }

        public PurchaseOrderHeader()
        {
            PurchaseOrderDetail = new HashSet<PurchaseOrderDetail>();
        }
    }
}