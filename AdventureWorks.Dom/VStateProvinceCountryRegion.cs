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

    public partial class VStateProvinceCountryRegion
    {
        [Column("StateProvinceID")] public int StateProvinceId { get; set; }

        [Required] [StringLength(3)] public string StateProvinceCode { get; set; }

        public bool IsOnlyStateProvinceFlag { get; set; }

        [Required] [StringLength(50)] public string StateProvinceName { get; set; }

        [Column("TerritoryID")] public int TerritoryId { get; set; }

        [Required] [StringLength(3)] public string CountryRegionCode { get; set; }

        [Required] [StringLength(50)] public string CountryRegionName { get; set; }
    }
}