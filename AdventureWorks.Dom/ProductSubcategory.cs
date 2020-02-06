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

    [Table("ProductSubcategory", Schema = "Production")]
    public partial class ProductSubcategory
    {
        [Key] [Column("ProductSubcategoryID")] public int ProductSubcategoryId { get; set; }

        [Column("ProductCategoryID")] public int ProductCategoryId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductCategoryId))]
        [InverseProperty("ProductSubcategory")]
        public virtual ProductCategory ProductCategory { get; set; }

        [InverseProperty("ProductSubcategory")]
        public virtual ICollection<Product> Product { get; set; }

        public ProductSubcategory()
        {
            Product = new HashSet<Product>();
        }
    }
}