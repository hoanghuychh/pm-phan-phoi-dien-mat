namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PemisionDetail")]
    public partial class PemisionDetail
    {
        public int id { get; set; }

        public int PerDetail { get; set; }

        [Required]
        [StringLength(20)]
        public string Per_Action { get; set; }

        [StringLength(10)]
        public string Per { get; set; }
    }
}
