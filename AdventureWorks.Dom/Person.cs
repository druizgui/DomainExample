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

    [Table("Person", Schema = "Person")]
    public partial class Person
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Required] [StringLength(2)] public string PersonType { get; set; }

        public bool NameStyle { get; set; }

        [StringLength(8)] public string Title { get; set; }

        [Required] [StringLength(50)] public string FirstName { get; set; }

        [StringLength(50)] public string MiddleName { get; set; }

        [Required] [StringLength(50)] public string LastName { get; set; }

        [StringLength(10)] public string Suffix { get; set; }

        public int EmailPromotion { get; set; }

        [Column(TypeName = "xml")] public string AdditionalContactInfo { get; set; }

        [Column(TypeName = "xml")] public string Demographics { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty("Person")]
        public virtual BusinessEntity BusinessEntity { get; set; }

        [InverseProperty("BusinessEntity")] public virtual Employee Employee { get; set; }

        [InverseProperty("BusinessEntity")] public virtual Password Password { get; set; }

        [InverseProperty("Person")] public virtual ICollection<BusinessEntityContact> BusinessEntityContact { get; set; }

        [InverseProperty("Person")] public virtual ICollection<Customer> Customer { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<EmailAddress> EmailAddress { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<PersonPhone> PersonPhone { get; set; }

        public Person()
        {
            BusinessEntityContact = new HashSet<BusinessEntityContact>();
            Customer = new HashSet<Customer>();
            EmailAddress = new HashSet<EmailAddress>();
            PersonCreditCard = new HashSet<PersonCreditCard>();
            PersonPhone = new HashSet<PersonPhone>();
        }
    }
}