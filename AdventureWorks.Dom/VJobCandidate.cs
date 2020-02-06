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

    public partial class VJobCandidate
    {
        [Column("JobCandidateID")] public int JobCandidateId { get; set; }

        [Column("BusinessEntityID")] public int? BusinessEntityId { get; set; }

        [Column("Name.Prefix")]
        [StringLength(30)]
        public string NamePrefix { get; set; }

        [Column("Name.First")]
        [StringLength(30)]
        public string NameFirst { get; set; }

        [Column("Name.Middle")]
        [StringLength(30)]
        public string NameMiddle { get; set; }

        [Column("Name.Last")]
        [StringLength(30)]
        public string NameLast { get; set; }

        [Column("Name.Suffix")]
        [StringLength(30)]
        public string NameSuffix { get; set; }

        public string Skills { get; set; }

        [Column("Addr.Type")]
        [StringLength(30)]
        public string AddrType { get; set; }

        [Column("Addr.Loc.CountryRegion")]
        [StringLength(100)]
        public string AddrLocCountryRegion { get; set; }

        [Column("Addr.Loc.State")]
        [StringLength(100)]
        public string AddrLocState { get; set; }

        [Column("Addr.Loc.City")]
        [StringLength(100)]
        public string AddrLocCity { get; set; }

        [Column("Addr.PostalCode")]
        [StringLength(20)]
        public string AddrPostalCode { get; set; }

        [Column("EMail")] public string Email { get; set; }

        public string WebSite { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }
    }
}