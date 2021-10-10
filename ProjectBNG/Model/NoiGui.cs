namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoiGui")]
    public partial class NoiGui
    {
        public int id { get; set; }

        [StringLength(265)]
        public string Ma { get; set; }

        [StringLength(265)]
        public string Ten { get; set; }
    }
}
