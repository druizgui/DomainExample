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

    [Table("CreditCard", Schema = "Sales")]
    public partial class CreditCard
    {
        [Key] [Column("CreditCardID")] public int CreditCardId { get; set; }

        [Required] [StringLength(50)] public string CardType { get; set; }

        [Required] [StringLength(25)] public string CardNumber { get; set; }

        public byte ExpMonth { get; set; }
        public short ExpYear { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("CreditCard")] public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }

        [InverseProperty("CreditCard")] public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }

        public CreditCard()
        {
            PersonCreditCard = new HashSet<PersonCreditCard>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }
    }
}