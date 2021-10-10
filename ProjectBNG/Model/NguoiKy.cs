namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NguoiKy")]
    public partial class NguoiKy
    {
        public int id { get; set; }

        [StringLength(265)]
        public string TenNguoiKy { get; set; }

        [StringLength(265)]
        public string ChucDanh { get; set; }

        public bool? MacDinh { get; set; }

        [Column(TypeName = "image")]
        public byte[] ChuKy { get; set; }
    }
}
