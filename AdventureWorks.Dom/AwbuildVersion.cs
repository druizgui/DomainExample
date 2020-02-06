﻿namespace AdventureWorks.Dom
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("AWBuildVersion")]
    public partial class AwbuildVersion
    {
        [Key]
        [Column("SystemInformationID")]
        public byte SystemInformationId { get; set; }
        [Required]
        [Column("Database Version")]
        [StringLength(25)]
        public string DatabaseVersion { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime VersionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ModifiedDate { get; set; }
    }
}
