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

    [Table("PersonPhone", Schema = "Person")]
    public partial class PersonPhone
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Key] [StringLength(25)] public string PhoneNumber { get; set; }

        [Key] [Column("PhoneNumberTypeID")] public int PhoneNumberTypeId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty(nameof(Person.PersonPhone))]
        public virtual Person BusinessEntity { get; set; }

        [ForeignKey(nameof(PhoneNumberTypeId))]
        [InverseProperty("PersonPhone")]
        public virtual PhoneNumberType PhoneNumberType { get; set; }
    }
}