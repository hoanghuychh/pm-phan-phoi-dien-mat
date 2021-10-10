namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NoiNhan")]
    public partial class NoiNhan
    {
        public int id { get; set; }

        [Required]
        [StringLength(20)]
        public string MaNoiNhan { get; set; }

        [Required]
        [StringLength(265)]
        public string TenNoiNhan { get; set; }

        [Required]
        [StringLength(20)]
        public string Loai { get; set; }

        public int SoBaoMat { get; set; }

        [StringLength(265)]
        public string Nhom { get; set; }

        public int? SoThuTu { get; set; }

        public bool? CoBi { get; set; }

        public bool? DangHoatDong { get; set; }

        [StringLength(50)]
        public string CoSo { get; set; }
    }
}
