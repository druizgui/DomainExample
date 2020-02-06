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

    public partial class DatabaseLog
    {
        [Key] [Column("DatabaseLogID")] public int DatabaseLogId { get; set; }

        [Column(TypeName = "datetime")] public DateTime PostTime { get; set; }

        [Required] [StringLength(128)] public string DatabaseUser { get; set; }

        [Required] [StringLength(128)] public string Event { get; set; }

        [StringLength(128)] public string Schema { get; set; }

        [StringLength(128)] public string Object { get; set; }

        [Required] [Column("TSQL")] public string Tsql { get; set; }

        [Required] [Column(TypeName = "xml")] public string XmlEvent { get; set; }
    }
}