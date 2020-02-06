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

    [Table("ProductPhoto", Schema = "Production")]
    public partial class ProductPhoto
    {
        [Key] [Column("ProductPhotoID")] public int ProductPhotoId { get; set; }

        public byte[] ThumbNailPhoto { get; set; }

        [StringLength(50)] public string ThumbnailPhotoFileName { get; set; }

        public byte[] LargePhoto { get; set; }

        [StringLength(50)] public string LargePhotoFileName { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("ProductPhoto")] public virtual ICollection<ProductProductPhoto> ProductProductPhoto { get; set; }

        public ProductPhoto()
        {
            ProductProductPhoto = new HashSet<ProductProductPhoto>();
        }
    }
}