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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class VStoreWithContacts
    {
        [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string ContactType { get; set; }

        [StringLength(8)] public string Title { get; set; }

        [Required] [StringLength(50)] public string FirstName { get; set; }

        [StringLength(50)] public string MiddleName { get; set; }

        [Required] [StringLength(50)] public string LastName { get; set; }

        [StringLength(10)] public string Suffix { get; set; }

        [StringLength(25)] public string PhoneNumber { get; set; }

        [StringLength(50)] public string PhoneNumberType { get; set; }

        [StringLength(50)] public string EmailAddress { get; set; }

        public int EmailPromotion { get; set; }
    }
}