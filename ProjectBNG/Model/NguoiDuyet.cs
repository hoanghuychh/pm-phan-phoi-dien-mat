namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiDuyet")]
    public partial class NguoiDuyet
    {
        public int id { get; set; }

        [StringLength(265)]
        public string TenNguoiDuyet { get; set; }

        public bool? MacDinh { get; set; }

        [Column(TypeName = "image")]
        public byte[] ChuKy { get; set; }
    }
}
