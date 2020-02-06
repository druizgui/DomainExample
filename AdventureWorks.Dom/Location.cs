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

    [Table("Location", Schema = "Production")]
    public partial class Location
    {
        [Key] [Column("LocationID")] public short LocationId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "smallmoney")] public decimal CostRate { get; set; }

        [Column(TypeName = "decimal(8, 2)")] public decimal Availability { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("Location")] public virtual ICollection<ProductInventory> ProductInventory { get; set; }

        [InverseProperty("Location")] public virtual ICollection<WorkOrderRouting> WorkOrderRouting { get; set; }

        public Location()
        {
            ProductInventory = new HashSet<ProductInventory>();
            WorkOrderRouting = new HashSet<WorkOrderRouting>();
        }
    }
}