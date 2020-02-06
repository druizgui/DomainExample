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

    [Table("ProductModelProductDescriptionCulture", Schema = "Production")]
    public partial class ProductModelProductDescriptionCulture
    {
        [Key] [Column("ProductModelID")] public int ProductModelId { get; set; }

        [Key] [Column("ProductDescriptionID")] public int ProductDescriptionId { get; set; }

        [Key]
        [Column("CultureID")]
        [StringLength(6)]
        public string CultureId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(CultureId))]
        [InverseProperty("ProductModelProductDescriptionCulture")]
        public virtual Culture Culture { get; set; }

        [ForeignKey(nameof(ProductDescriptionId))]
        [InverseProperty("ProductModelProductDescriptionCulture")]
        public virtual ProductDescription ProductDescription { get; set; }

        [ForeignKey(nameof(ProductModelId))]
        [InverseProperty("ProductModelProductDescriptionCulture")]
        public virtual ProductModel ProductModel { get; set; }
    }
}