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

    [Table("BusinessEntityAddress", Schema = "Person")]
    public partial class BusinessEntityAddress
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Key] [Column("AddressID")] public int AddressId { get; set; }

        [Key] [Column("AddressTypeID")] public int AddressTypeId { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(AddressId))]
        [InverseProperty("BusinessEntityAddress")]
        public virtual Address Address { get; set; }

        [ForeignKey(nameof(AddressTypeId))]
        [InverseProperty("BusinessEntityAddress")]
        public virtual AddressType AddressType { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty("BusinessEntityAddress")]
        public virtual BusinessEntity BusinessEntity { get; set; }
    }
}