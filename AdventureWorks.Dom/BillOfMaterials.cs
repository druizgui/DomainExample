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

    [Table("BillOfMaterials", Schema = "Production")]
    public partial class BillOfMaterials
    {
        [Key] [Column("BillOfMaterialsID")] public int BillOfMaterialsId { get; set; }

        [Column("ProductAssemblyID")] public int? ProductAssemblyId { get; set; }

        [Column("ComponentID")] public int ComponentId { get; set; }

        [Column(TypeName = "datetime")] public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? EndDate { get; set; }

        [Required] [StringLength(3)] public string UnitMeasureCode { get; set; }

        [Column("BOMLevel")] public short Bomlevel { get; set; }

        [Column(TypeName = "decimal(8, 2)")] public decimal PerAssemblyQty { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ComponentId))]
        [InverseProperty(nameof(Product.BillOfMaterialsComponent))]
        public virtual Product Component { get; set; }

        [ForeignKey(nameof(ProductAssemblyId))]
        [InverseProperty(nameof(Product.BillOfMaterialsProductAssembly))]
        public virtual Product ProductAssembly { get; set; }

        [ForeignKey(nameof(UnitMeasureCode))]
        [InverseProperty(nameof(UnitMeasure.BillOfMaterials))]
        public virtual UnitMeasure UnitMeasureCodeNavigation { get; set; }
    }
}