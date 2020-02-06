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

    [Table("SalesPerson", Schema = "Sales")]
    public partial class SalesPerson
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Column("TerritoryID")] public int? TerritoryId { get; set; }

        [Column(TypeName = "money")] public decimal? SalesQuota { get; set; }

        [Column(TypeName = "money")] public decimal Bonus { get; set; }

        [Column(TypeName = "smallmoney")] public decimal CommissionPct { get; set; }

        [Column("SalesYTD", TypeName = "money")]
        public decimal SalesYtd { get; set; }

        [Column(TypeName = "money")] public decimal SalesLastYear { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty(nameof(Employee.SalesPerson))]
        public virtual Employee BusinessEntity { get; set; }

        [ForeignKey(nameof(TerritoryId))]
        [InverseProperty(nameof(SalesTerritory.SalesPerson))]
        public virtual SalesTerritory Territory { get; set; }

        [InverseProperty("SalesPerson")] public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<SalesPersonQuotaHistory> SalesPersonQuotaHistory { get; set; }

        [InverseProperty("BusinessEntity")] public virtual ICollection<SalesTerritoryHistory> SalesTerritoryHistory { get; set; }

        [InverseProperty("SalesPerson")] public virtual ICollection<Store> Store { get; set; }

        public SalesPerson()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
            SalesPersonQuotaHistory = new HashSet<SalesPersonQuotaHistory>();
            SalesTerritoryHistory = new HashSet<SalesTerritoryHistory>();
            Store = new HashSet<Store>();
        }
    }
}