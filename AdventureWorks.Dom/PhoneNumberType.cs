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

    [Table("PhoneNumberType", Schema = "Person")]
    public partial class PhoneNumberType
    {
        [Key] [Column("PhoneNumberTypeID")] public int PhoneNumberTypeId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("PhoneNumberType")] public virtual ICollection<PersonPhone> PersonPhone { get; set; }

        public PhoneNumberType()
        {
            PersonPhone = new HashSet<PersonPhone>();
        }
    }
}