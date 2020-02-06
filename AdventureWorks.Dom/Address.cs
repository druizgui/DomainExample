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

    [Table("Address", Schema = "Person")]
    public partial class Address
    {
        [Key] [Column("AddressID")] public int AddressId { get; set; }

        [Required] [StringLength(60)] public string AddressLine1 { get; set; }

        [StringLength(60)] public string AddressLine2 { get; set; }

        [Required] [StringLength(30)] public string City { get; set; }

        [Column("StateProvinceID")] public int StateProvinceId { get; set; }

        [Required] [StringLength(15)] public string PostalCode { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(StateProvinceId))]
        [InverseProperty("Address")]
        public virtual StateProvince StateProvince { get; set; }

        [InverseProperty("Address")] public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }

        [InverseProperty(nameof(SalesOrderHeader.BillToAddress))]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderBillToAddress { get; set; }

        [InverseProperty(nameof(SalesOrderHeader.ShipToAddress))]
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaderShipToAddress { get; set; }

        public Address()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            SalesOrderHeaderBillToAddress = new HashSet<SalesOrderHeader>();
            SalesOrderHeaderShipToAddress = new HashSet<SalesOrderHeader>();
        }
    }
}