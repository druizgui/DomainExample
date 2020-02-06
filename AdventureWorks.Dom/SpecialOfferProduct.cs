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

    [Table("SpecialOfferProduct", Schema = "Sales")]
    public partial class SpecialOfferProduct
    {
        [Key] [Column("SpecialOfferID")] public int SpecialOfferId { get; set; }

        [Key] [Column("ProductID")] public int ProductId { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("SpecialOfferProduct")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(SpecialOfferId))]
        [InverseProperty("SpecialOfferProduct")]
        public virtual SpecialOffer SpecialOffer { get; set; }

        [InverseProperty("SpecialOfferProduct")]
        public virtual ICollection<SalesOrderDetail> SalesOrderDetail { get; set; }

        public SpecialOfferProduct()
        {
            SalesOrderDetail = new HashSet<SalesOrderDetail>();
        }
    }
}