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

    [Table("StateProvince", Schema = "Person")]
    public partial class StateProvince
    {
        [Key] [Column("StateProvinceID")] public int StateProvinceId { get; set; }

        [Required] [StringLength(3)] public string StateProvinceCode { get; set; }

        [Required] [StringLength(3)] public string CountryRegionCode { get; set; }

        [Required] public bool? IsOnlyStateProvinceFlag { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column("TerritoryID")] public int TerritoryId { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(CountryRegionCode))]
        [InverseProperty(nameof(CountryRegion.StateProvince))]
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }

        [ForeignKey(nameof(TerritoryId))]
        [InverseProperty(nameof(SalesTerritory.StateProvince))]
        public virtual SalesTerritory Territory { get; set; }

        [InverseProperty("StateProvince")] public virtual ICollection<Address> Address { get; set; }

        [InverseProperty("StateProvince")] public virtual ICollection<SalesTaxRate> SalesTaxRate { get; set; }

        public StateProvince()
        {
            Address = new HashSet<Address>();
            SalesTaxRate = new HashSet<SalesTaxRate>();
        }
    }
}