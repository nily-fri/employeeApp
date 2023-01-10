using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AAAA.Models.Database.NilyDb
{
    [Table("Invoice")]
    public partial class Invoice
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        public int? ProductId { get; set; }
        public int? Amount { get; set; }
    }
}
