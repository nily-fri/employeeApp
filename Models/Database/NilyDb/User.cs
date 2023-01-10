using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models.Database.NilyDb
{
    [Table("user")]
    public partial class User
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("full_name")]
        [StringLength(45)]
        public string? FullName { get; set; }
        [Column("user_name")]
        [StringLength(45)]
        public string? UserName { get; set; }
        [Column("password")]
        [StringLength(45)]
        public string? Password { get; set; }
        [Column("num_of_actions")]
        public int? NumOfActions { get; set; }
    }
}
