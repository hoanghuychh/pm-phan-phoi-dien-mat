namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Permision")]
    public partial class Permision
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string NamePer { get; set; }

        [StringLength(256)]
        public string DescriptionPer { get; set; }
    }
}
