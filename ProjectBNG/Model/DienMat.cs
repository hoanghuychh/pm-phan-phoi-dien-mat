namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienMat")]
    public partial class DienMat
    {
        public int ID { get; set; }

        [StringLength(265)]
        public string LuuFile { get; set; }

        [StringLength(265)]
        public string FileDinhKem { get; set; }

        [StringLength(265)]
        public string NoiGui { get; set; }

        [StringLength(265)]
        public string TrichYeu { get; set; }

        [StringLength(20)]
        public string DoMat { get; set; }

        [StringLength(20)]
        public string DoMatFile { get; set; }

        public int? MaDienMat { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? Ngay { get; set; }

        [StringLength(265)]
        public string GhiChu { get; set; }

        [StringLength(20)]
        public string Loai { get; set; }

        public int? BanIn { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime NgayIn { get; set; }

        [StringLength(256)]
        public string NguoiDuyet { get; set; }

        [StringLength(256)]
        public string NguoiKy { get; set; }

        [StringLength(256)]
        public string ChucDanh { get; set; }

        [StringLength(256)]
        public string DsNoiNhan { get; set; }

        public int? Trang { get; set; }

        public int? idUsername { get; set; }

        [StringLength(50)]
        public string NguoiIn { get; set; }

        public int? TinhSoDien { get; set; }

        public int? SoBiThu { get; set; }

        public virtual USER USER { get; set; }
    }
}
