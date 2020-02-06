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

    [Table("ProductReview", Schema = "Production")]
    public partial class ProductReview
    {
        [Key] [Column("ProductReviewID")] public int ProductReviewId { get; set; }

        [Column("ProductID")] public int ProductId { get; set; }

        [Required] [StringLength(50)] public string ReviewerName { get; set; }

        [Column(TypeName = "datetime")] public DateTime ReviewDate { get; set; }

        [Required] [StringLength(50)] public string EmailAddress { get; set; }

        public int Rating { get; set; }

        [StringLength(3850)] public string Comments { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(ProductId))]
        [InverseProperty("ProductReview")]
        public virtual Product Product { get; set; }
    }
}