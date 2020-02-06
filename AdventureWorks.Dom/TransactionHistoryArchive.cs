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

    [Table("TransactionHistoryArchive", Schema = "Production")]
    public partial class TransactionHistoryArchive
    {
        [Key] [Column("TransactionID")] public int TransactionId { get; set; }

        [Column("ProductID")] public int ProductId { get; set; }

        [Column("ReferenceOrderID")] public int ReferenceOrderId { get; set; }

        [Column("ReferenceOrderLineID")] public int ReferenceOrderLineId { get; set; }

        [Column(TypeName = "datetime")] public DateTime TransactionDate { get; set; }

        [Required] [StringLength(1)] public string TransactionType { get; set; }

        public int Quantity { get; set; }

        [Column(TypeName = "money")] public decimal ActualCost { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }
    }
}