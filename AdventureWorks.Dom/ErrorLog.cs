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

    public partial class ErrorLog
    {
        [Key] [Column("ErrorLogID")] public int ErrorLogId { get; set; }

        [Column(TypeName = "datetime")] public DateTime ErrorTime { get; set; }

        [Required] [StringLength(128)] public string UserName { get; set; }

        public int ErrorNumber { get; set; }
        public int? ErrorSeverity { get; set; }
        public int? ErrorState { get; set; }

        [StringLength(126)] public string ErrorProcedure { get; set; }

        public int? ErrorLine { get; set; }

        [Required] [StringLength(4000)] public string ErrorMessage { get; set; }
    }
}