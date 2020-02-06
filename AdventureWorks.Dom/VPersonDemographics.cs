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

    public partial class VPersonDemographics
    {
        [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Column("TotalPurchaseYTD", TypeName = "money")]
        public decimal? TotalPurchaseYtd { get; set; }

        [Column(TypeName = "datetime")] public DateTime? DateFirstPurchase { get; set; }

        [Column(TypeName = "datetime")] public DateTime? BirthDate { get; set; }

        [StringLength(1)] public string MaritalStatus { get; set; }

        [StringLength(30)] public string YearlyIncome { get; set; }

        [StringLength(1)] public string Gender { get; set; }

        public int? TotalChildren { get; set; }
        public int? NumberChildrenAtHome { get; set; }

        [StringLength(30)] public string Education { get; set; }

        [StringLength(30)] public string Occupation { get; set; }

        public bool? HomeOwnerFlag { get; set; }
        public int? NumberCarsOwned { get; set; }
    }
}