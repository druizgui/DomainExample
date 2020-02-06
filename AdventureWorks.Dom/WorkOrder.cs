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

    [Table("WorkOrder", Schema = "Production")]
    public partial class WorkOrder
    {
        [Key] [Column("WorkOrderID")] public int WorkOrderId { get; set; }

        [Column("ProductID")] public int ProductId { get; set; }

        public int OrderQty { get; set; }
        public int StockedQty { get; set; }
        public short ScrappedQty { get; set; }

        [Column(TypeName = "datetime")] public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? EndDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime DueDate { get; set; }

        [Column("ScrapReasonID")] public short? ScrapReasonId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("WorkOrder")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(ScrapReasonId))]
        [InverseProperty("WorkOrder")]
        public virtual ScrapReason ScrapReason { get; set; }

        [InverseProperty("WorkOrder")] public virtual ICollection<WorkOrderRouting> WorkOrderRouting { get; set; }

        public WorkOrder()
        {
            WorkOrderRouting = new HashSet<WorkOrderRouting>();
        }
    }
}