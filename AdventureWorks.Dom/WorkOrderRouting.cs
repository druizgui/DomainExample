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

    [Table("WorkOrderRouting", Schema = "Production")]
    public partial class WorkOrderRouting
    {
        [Key] [Column("WorkOrderID")] public int WorkOrderId { get; set; }

        [Key] [Column("ProductID")] public int ProductId { get; set; }

        [Key] public short OperationSequence { get; set; }

        [Column("LocationID")] public short LocationId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ScheduledStartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime ScheduledEndDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? ActualStartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? ActualEndDate { get; set; }

        [Column(TypeName = "decimal(9, 4)")] public decimal? ActualResourceHrs { get; set; }

        [Column(TypeName = "money")] public decimal PlannedCost { get; set; }

        [Column(TypeName = "money")] public decimal? ActualCost { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(LocationId))]
        [InverseProperty("WorkOrderRouting")]
        public virtual Location Location { get; set; }

        [ForeignKey(nameof(WorkOrderId))]
        [InverseProperty("WorkOrderRouting")]
        public virtual WorkOrder WorkOrder { get; set; }
    }
}