namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhanLoaiNoiNhan")]
    public partial class PhanLoaiNoiNhan
    {
        [StringLength(50)]
        public string PhanLoai { get; set; }

        public int id { get; set; }
    }
}
