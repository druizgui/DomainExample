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

    [Table("CurrencyRate", Schema = "Sales")]
    public partial class CurrencyRate
    {
        [Key] [Column("CurrencyRateID")] public int CurrencyRateId { get; set; }

        [Column(TypeName = "datetime")] public DateTime CurrencyRateDate { get; set; }

        [Required] [StringLength(3)] public string FromCurrencyCode { get; set; }

        [Required] [StringLength(3)] public string ToCurrencyCode { get; set; }

        [Column(TypeName = "money")] public decimal AverageRate { get; set; }

        [Column(TypeName = "money")] public decimal EndOfDayRate { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(FromCurrencyCode))]
        [InverseProperty(nameof(Currency.CurrencyRateFromCurrencyCodeNavigation))]
        public virtual Currency FromCurrencyCodeNavigation { get; set; }

        [ForeignKey(nameof(ToCurrencyCode))]
        [InverseProperty(nameof(Currency.CurrencyRateToCurrencyCodeNavigation))]
        public virtual Currency ToCurrencyCodeNavigation { get; set; }

        [InverseProperty("CurrencyRate")] public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }

        public CurrencyRate()
        {
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }
    }
}