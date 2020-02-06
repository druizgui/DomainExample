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

    [Table("BusinessEntityContact", Schema = "Person")]
    public partial class BusinessEntityContact
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Key] [Column("PersonID")] public int PersonId { get; set; }

        [Key] [Column("ContactTypeID")] public int ContactTypeId { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty("BusinessEntityContact")]
        public virtual BusinessEntity BusinessEntity { get; set; }

        [ForeignKey(nameof(ContactTypeId))]
        [InverseProperty("BusinessEntityContact")]
        public virtual ContactType ContactType { get; set; }

        [ForeignKey(nameof(PersonId))]
        [InverseProperty("BusinessEntityContact")]
        public virtual Person Person { get; set; }
    }
}