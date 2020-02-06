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

    public partial class VProductModelInstructions
    {
        [Column("ProductModelID")] public int ProductModelId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public string Instructions { get; set; }

        [Column("LocationID")] public int? LocationId { get; set; }

        [Column(TypeName = "decimal(9, 4)")] public decimal? SetupHours { get; set; }

        [Column(TypeName = "decimal(9, 4)")] public decimal? MachineHours { get; set; }

        [Column(TypeName = "decimal(9, 4)")] public decimal? LaborHours { get; set; }

        public int? LotSize { get; set; }

        [StringLength(1024)] public string Step { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }
    }
}