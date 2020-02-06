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

    [Table("ProductProductPhoto", Schema = "Production")]
    public partial class ProductProductPhoto
    {
        [Key] [Column("ProductID")] public int ProductId { get; set; }

        [Key] [Column("ProductPhotoID")] public int ProductPhotoId { get; set; }

        public bool Primary { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductProductPhoto")]
        public virtual Product Product { get; set; }

        [ForeignKey(nameof(ProductPhotoId))]
        [InverseProperty("ProductProductPhoto")]
        public virtual ProductPhoto ProductPhoto { get; set; }
    }
}