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

    [Table("ProductModel", Schema = "Production")]
    public partial class ProductModel
    {
        [Key] [Column("ProductModelID")] public int ProductModelId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "xml")] public string CatalogDescription { get; set; }

        [Column(TypeName = "xml")] public string Instructions { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("ProductModel")] public virtual ICollection<Product> Product { get; set; }

        [InverseProperty("ProductModel")] public virtual ICollection<ProductModelIllustration> ProductModelIllustration { get; set; }

        [InverseProperty("ProductModel")] public virtual ICollection<ProductModelProductDescriptionCulture> ProductModelProductDescriptionCulture { get; set; }

        public ProductModel()
        {
            Product = new HashSet<Product>();
            ProductModelIllustration = new HashSet<ProductModelIllustration>();
            ProductModelProductDescriptionCulture = new HashSet<ProductModelProductDescriptionCulture>();
        }
    }
}