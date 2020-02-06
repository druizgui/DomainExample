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

    [Table("ShipMethod", Schema = "Purchasing")]
    public partial class ShipMethod
    {
        [Key] [Column("ShipMethodID")] public int ShipMethodId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "money")] public decimal ShipBase { get; set; }

        [Column(TypeName = "money")] public decimal ShipRate { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("ShipMethod")] public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }

        [InverseProperty("ShipMethod")] public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }

        public ShipMethod()
        {
            PurchaseOrderHeader = new HashSet<PurchaseOrderHeader>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }
    }
}