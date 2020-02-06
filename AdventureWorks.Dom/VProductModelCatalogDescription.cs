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

    public partial class VProductModelCatalogDescription
    {
        [Column("ProductModelID")] public int ProductModelId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        public string Summary { get; set; }
        public string Manufacturer { get; set; }

        [StringLength(30)] public string Copyright { get; set; }

        [Column("ProductURL")]
        [StringLength(256)]
        public string ProductUrl { get; set; }

        [StringLength(256)] public string WarrantyPeriod { get; set; }

        [StringLength(256)] public string WarrantyDescription { get; set; }

        [StringLength(256)] public string NoOfYears { get; set; }

        [StringLength(256)] public string MaintenanceDescription { get; set; }

        [StringLength(256)] public string Wheel { get; set; }

        [StringLength(256)] public string Saddle { get; set; }

        [StringLength(256)] public string Pedal { get; set; }

        public string BikeFrame { get; set; }

        [StringLength(256)] public string Crankset { get; set; }

        [StringLength(256)] public string PictureAngle { get; set; }

        [StringLength(256)] public string PictureSize { get; set; }

        [Column("ProductPhotoID")]
        [StringLength(256)]
        public string ProductPhotoId { get; set; }

        [StringLength(256)] public string Material { get; set; }

        [StringLength(256)] public string Color { get; set; }

        [StringLength(256)] public string ProductLine { get; set; }

        [StringLength(256)] public string Style { get; set; }

        [StringLength(1024)] public string RiderExperience { get; set; }

        [Column("rowguid")] public Guid Rowguid { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }
    }
}