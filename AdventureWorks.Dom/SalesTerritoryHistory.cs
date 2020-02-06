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

    [Table("SalesTerritoryHistory", Schema = "Sales")]
    public partial class SalesTerritoryHistory
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Key] [Column("TerritoryID")] public int TerritoryId { get; set; }

        [Key] [Column(TypeName = "datetime")] public DateTime StartDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime? EndDate { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty(nameof(SalesPerson.SalesTerritoryHistory))]
        public virtual SalesPerson BusinessEntity { get; set; }

        [ForeignKey(nameof(TerritoryId))]
        [InverseProperty(nameof(SalesTerritory.SalesTerritoryHistory))]
        public virtual SalesTerritory Territory { get; set; }
    }
}