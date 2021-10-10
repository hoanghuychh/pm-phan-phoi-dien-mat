namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FileDinhKemDienMat")]
    public partial class FileDinhKemDienMat
    {
        public int id { get; set; }

        [StringLength(256)]
        public string FileDinhKem { get; set; }

        public int? MaDienMat { get; set; }
    }
}
