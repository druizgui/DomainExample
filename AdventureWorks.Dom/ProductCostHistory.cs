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

    [Table("ProductCostHistory", Schema = "Production")]
    public partial class ProductCostHistory
    {
        [Key] [Column("ProductID")] public int ProductId { get; set; }

        [Key] [Column(TypeName = "datetime")] public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? EndDate { get; set; }

        [Column(TypeName = "money")] public decimal StandardCost { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductCostHistory")]
        public virtual Product Product { get; set; }
    }
}