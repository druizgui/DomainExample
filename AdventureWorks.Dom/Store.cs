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

    [Table("Store", Schema = "Sales")]
    public partial class Store
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column("SalesPersonID")] public int? SalesPersonId { get; set; }

        [Column(TypeName = "xml")] public string Demographics { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty("Store")]
        public virtual BusinessEntity BusinessEntity { get; set; }

        [ForeignKey(nameof(SalesPersonId))]
        [InverseProperty("Store")]
        public virtual SalesPerson SalesPerson { get; set; }

        [InverseProperty("Store")] public virtual ICollection<Customer> Customer { get; set; }

        public Store()
        {
            Customer = new HashSet<Customer>();
        }
    }
}