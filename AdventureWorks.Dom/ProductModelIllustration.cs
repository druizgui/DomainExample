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

    [Table("ProductModelIllustration", Schema = "Production")]
    public partial class ProductModelIllustration
    {
        [Key] [Column("ProductModelID")] public int ProductModelId { get; set; }

        [Key] [Column("IllustrationID")] public int IllustrationId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(IllustrationId))]
        [InverseProperty("ProductModelIllustration")]
        public virtual Illustration Illustration { get; set; }

        [ForeignKey(nameof(ProductModelId))]
        [InverseProperty("ProductModelIllustration")]
        public virtual ProductModel ProductModel { get; set; }
    }
}