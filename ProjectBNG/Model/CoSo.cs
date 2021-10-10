namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CoSo")]
    public partial class CoSo
    {
        [StringLength(50)]
        public string TenCoSo { get; set; }

        public int id { get; set; }
    }
}
