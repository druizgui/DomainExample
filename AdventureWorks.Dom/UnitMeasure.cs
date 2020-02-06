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

    [Table("UnitMeasure", Schema = "Production")]
    public partial class UnitMeasure
    {
        [Key] [StringLength(3)] public string UnitMeasureCode { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("UnitMeasureCodeNavigation")]
        public virtual ICollection<BillOfMaterials> BillOfMaterials { get; set; }

        [InverseProperty(nameof(Product.SizeUnitMeasureCodeNavigation))]
        public virtual ICollection<Product> ProductSizeUnitMeasureCodeNavigation { get; set; }

        [InverseProperty("UnitMeasureCodeNavigation")]
        public virtual ICollection<ProductVendor> ProductVendor { get; set; }

        [InverseProperty(nameof(Product.WeightUnitMeasureCodeNavigation))]
        public virtual ICollection<Product> ProductWeightUnitMeasureCodeNavigation { get; set; }

        public UnitMeasure()
        {
            BillOfMaterials = new HashSet<BillOfMaterials>();
            ProductSizeUnitMeasureCodeNavigation = new HashSet<Product>();
            ProductVendor = new HashSet<ProductVendor>();
            ProductWeightUnitMeasureCodeNavigation = new HashSet<Product>();
        }
    }
}