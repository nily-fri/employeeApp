using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models.Database.NilyDb
{
    [Table("shift")]
    public partial class Shift
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }
        [Column("start_time")]
        public int? StartTime { get; set; }
        [Column("end_time")]
        public int? EndTime { get; set; }
    }
}
