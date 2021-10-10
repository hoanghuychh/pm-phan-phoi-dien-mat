namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienMatDaPhanPhoi")]
    public partial class DienMatDaPhanPhoi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        public DateTime? Ngay { get; set; }

        [StringLength(265)]
        public string GhiChu { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string Loai { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SoBaoMat { get; set; }

        public int? BanIn { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime NgayIn { get; set; }

        [StringLength(256)]
        public string NguoiDuyet { get; set; }

        [StringLength(256)]
        public string NguoiKy { get; set; }

        [StringLength(256)]
        public string ChucDanh { get; set; }

        [Column(TypeName = "image")]
        public byte[] ChuKy { get; set; }
    }
}
