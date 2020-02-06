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

    [Table("BusinessEntity", Schema = "Person")]
    public partial class BusinessEntity
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("BusinessEntity")] public virtual Person Person { get; set; }

        [InverseProperty("BusinessEntity")] public virtual Store Store { get; set; }

        [InverseProperty("BusinessEntity")] public virtual Vendor Vendor { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<BusinessEntityAddress> BusinessEntityAddress { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }

        public BusinessEntity()
        {
            BusinessEntityAddress = new HashSet<BusinessEntityAddress>();
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
        }
    }
}