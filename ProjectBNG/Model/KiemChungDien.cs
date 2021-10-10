namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KiemChungDien")]
    public partial class KiemChungDien
    {
        public int id { get; set; }

        [StringLength(265)]
        public string DanhSachDien { get; set; }

        public int? TongSoTrang { get; set; }

        [StringLength(265)]
        public string TenNoiNhan { get; set; }

        public int? SoLuongDien { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? NgayIn { get; set; }
    }
}
