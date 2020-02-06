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

    [Table("SpecialOffer", Schema = "Sales")]
    public partial class SpecialOffer
    {
        [Key] [Column("SpecialOfferID")] public int SpecialOfferId { get; set; }

        [Required] [StringLength(255)] public string Description { get; set; }

        [Column(TypeName = "smallmoney")] public decimal DiscountPct { get; set; }

        [Required] [StringLength(50)] public string Type { get; set; }

        [Required] [StringLength(50)] public string Category { get; set; }

        [Column(TypeName = "datetime")] public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime EndDate { get; set; }

        public int MinQty { get; set; }
        public int? MaxQty { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("SpecialOffer")] public virtual ICollection<SpecialOfferProduct> SpecialOfferProduct { get; set; }

        public SpecialOffer()
        {
            SpecialOfferProduct = new HashSet<SpecialOfferProduct>();
        }
    }
}