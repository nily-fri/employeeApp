using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models.Database.NilyDb
{
    [Table("department")]
    public partial class Department
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("name")]
        [StringLength(45)]
        public string? Name { get; set; }
        [Column("manager")]
        [StringLength(45)]
        public string? Manager { get; set; }
        [Column("manager_id")]
        public int? ManagerId { get; set; }
    }
}
