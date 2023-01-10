using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models.Database.NilyDb
{
    [Table("employee")]
    public partial class Employee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("first_name")]
        [StringLength(45)]
        public string? FirstName { get; set; }
        [Column("last_name")]
        [StringLength(45)]
        public string? LastName { get; set; }
        [Column("start_work_year")]
        public int? StartWorkYear { get; set; }
        [Column("department_id")]
        public int? DepartmentId { get; set; }
    }
}
