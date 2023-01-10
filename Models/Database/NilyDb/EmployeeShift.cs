using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models.Database.NilyDb
{
    [Table("employee_shift")]
    public partial class EmployeeShift
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("employee_id")]
        [StringLength(45)]
        public string? EmployeeId { get; set; }
        [Column("shift_id")]
        [StringLength(45)]
        public string? ShiftId { get; set; }
    }
}
