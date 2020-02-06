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

    [Table("Vendor", Schema = "Purchasing")]
    public partial class Vendor
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Required] [StringLength(15)] public string AccountNumber { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public byte CreditRating { get; set; }

        [Required] public bool? PreferredVendorStatus { get; set; }

        [Required] public bool? ActiveFlag { get; set; }

        [Column("PurchasingWebServiceURL")]
        [StringLength(1024)]
        public string PurchasingWebServiceUrl { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty("Vendor")]
        public virtual BusinessEntity BusinessEntity { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<ProductVendor> ProductVendor { get; set; }

        [InverseProperty("Vendor")] public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }

        public Vendor()
        {
            ProductVendor = new HashSet<ProductVendor>();
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
        }
    }
}