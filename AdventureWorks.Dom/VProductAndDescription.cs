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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class VProductAndDescription
    {
        [Column("ProductID")] public int ProductId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string ProductModel { get; set; }

        [Required]
        [Column("CultureID")]
        [StringLength(6)]
        public string CultureId { get; set; }

        [Required] [StringLength(400)] public string Description { get; set; }
    }
}