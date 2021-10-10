namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BiThu")]
    public partial class BiThu
    {
        public int id { get; set; }

        public DateTime Ngay { get; set; }

        [StringLength(265)]
        public string SoPhieu { get; set; }

        [StringLength(265)]
        public string KiNhan { get; set; }

        [StringLength(265)]
        public string TenNoiNhan { get; set; }

        public int? TongSo { get; set; }

        [StringLength(265)]
        public string DanhSachDienMat { get; set; }
    }
}
