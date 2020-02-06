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

    [Table("CountryRegionCurrency", Schema = "Sales")]
    public partial class CountryRegionCurrency
    {
        [Key] [StringLength(3)] public string CountryRegionCode { get; set; }

        [Key] [StringLength(3)] public string CurrencyCode { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(CountryRegionCode))]
        [InverseProperty(nameof(CountryRegion.CountryRegionCurrency))]
        public virtual CountryRegion CountryRegionCodeNavigation { get; set; }

        [ForeignKey(nameof(CurrencyCode))]
        [InverseProperty(nameof(Currency.CountryRegionCurrency))]
        public virtual Currency CurrencyCodeNavigation { get; set; }
    }
}