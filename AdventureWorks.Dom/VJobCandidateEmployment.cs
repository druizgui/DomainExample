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

    public partial class VJobCandidateEmployment
    {
        [Column("JobCandidateID")] public int JobCandidateId { get; set; }

        [Column("Emp.StartDate", TypeName = "datetime")]
        public DateTime? EmpStartDate { get; set; }

        [Column("Emp.EndDate", TypeName = "datetime")]
        public DateTime? EmpEndDate { get; set; }

        [Column("Emp.OrgName")]
        [StringLength(100)]
        public string EmpOrgName { get; set; }

        [Column("Emp.JobTitle")]
        [StringLength(100)]
        public string EmpJobTitle { get; set; }

        [Column("Emp.Responsibility")] public string EmpResponsibility { get; set; }

        [Column("Emp.FunctionCategory")] public string EmpFunctionCategory { get; set; }

        [Column("Emp.IndustryCategory")] public string EmpIndustryCategory { get; set; }

        [Column("Emp.Loc.CountryRegion")] public string EmpLocCountryRegion { get; set; }

        [Column("Emp.Loc.State")] public string EmpLocState { get; set; }

        [Column("Emp.Loc.City")] public string EmpLocCity { get; set; }
    }
}