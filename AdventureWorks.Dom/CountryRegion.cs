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

    [Table("CountryRegion", Schema = "Person")]
    public partial class CountryRegion
    {
        [Key] [StringLength(3)] public string CountryRegionCode { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("CountryRegionCodeNavigation")]
        public virtual ICollection<CountryRegionCurrency> CountryRegionCurrency { get; set; }

        [InverseProperty("CountryRegionCodeNavigation")]
        public virtual ICollection<SalesTerritory> SalesTerritory { get; set; }

        [InverseProperty("CountryRegionCodeNavigation")]
        public virtual ICollection<StateProvince> StateProvince { get; set; }

        public CountryRegion()
        {
            CountryRegionCurrency = new HashSet<CountryRegionCurrency>();
            SalesTerritory = new HashSet<SalesTerritory>();
            StateProvince = new HashSet<StateProvince>();
        }
    }
}