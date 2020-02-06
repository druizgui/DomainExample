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

    [Table("EmployeeDepartmentHistory", Schema = "HumanResources")]
    public partial class EmployeeDepartmentHistory
    {
        [Key] [Column("BusinessEntityID")] public int BusinessEntityId { get; set; }

        [Key] [Column("DepartmentID")] public short DepartmentId { get; set; }

        [Key] [Column("ShiftID")] public byte ShiftId { get; set; }

        [Key] [Column(TypeName = "date")] public DateTime StartDate { get; set; }

        [Column(TypeName = "date")] public DateTime? EndDate { get; set; }

        [Column(TypeName = "datetime")] public DateTime ModifiedDate { get; set; }

        [ForeignKey(nameof(BusinessEntityId))]
        [InverseProperty(nameof(Employee.EmployeeDepartmentHistory))]
        public virtual Employee BusinessEntity { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        [InverseProperty("EmployeeDepartmentHistory")]
        public virtual Department Department { get; set; }

        [ForeignKey(nameof(ShiftId))]
        [InverseProperty("EmployeeDepartmentHistory")]
        public virtual Shift Shift { get; set; }
    }
}