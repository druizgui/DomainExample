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

    [Table("PersonCreditCard", Schema = "Sales")]
    public partial class PersonCreditCard
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Key] [Column("CreditCardID")] public int CreditCardId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty(nameof(Person.PersonCreditCard))]
        public virtual Person BusinessEntity { get; set; }

        [ForeignKey(nameof(CreditCardId))]
        [InverseProperty("PersonCreditCard")]
        public virtual CreditCard CreditCard { get; set; }
    }
}