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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class VSalesPersonSalesByFiscalYears
    {
        [Column("SalesPersonID")] public int? SalesPersonId { get; set; }

        [StringLength(152)] public string FullName { get; set; }

        [Required] [StringLength(50)] public string JobTitle { get; set; }

        [Required] [StringLength(50)] public string SalesTerritory { get; set; }

        [Column("2002", TypeName = "money")] public decimal? _2002 { get; set; }

        [Column("2003", TypeName = "money")] public decimal? _2003 { get; set; }

        [Column("2004", TypeName = "money")] public decimal? _2004 { get; set; }
    }
}