namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TrangThai")]
    public partial class TrangThai
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string NameTrangThai { get; set; }
    }
}
