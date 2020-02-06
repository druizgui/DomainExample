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
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Department", Schema = "HumanResources")]
    public partial class Department
    {
        [Key] [Column("DepartmentID")] public short DepartmentId { get; set; }

        [Required] [StringLength(50)] public string Name { get; set; }

        [Required] [StringLength(50)] public string GroupName { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [InverseProperty("Department")] public virtual ICollection<EmployeeDepartmentHistory> EmployeeDepartmentHistory { get; set; }

        public Department()
        {
            EmployeeDepartmentHistory = new HashSet<EmployeeDepartmentHistory>();
        }
    }
}