﻿// -----------------------------------------------------------------
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

    public partial class VVendorWithAddresses
    {
        [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string AddressType { get; set; }

        [Required] [StringLength(60)] public string AddressLine1 { get; set; }

        [StringLength(60)] public string AddressLine2 { get; set; }

        [Required] [StringLength(30)] public string City { get; set; }

        [Required] [StringLength(50)] public string StateProvinceName { get; set; }

        [Required] [StringLength(15)] public string PostalCode { get; set; }

        [Required] [StringLength(50)] public string CountryRegionName { get; set; }
    }
}