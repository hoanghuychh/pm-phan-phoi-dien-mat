namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuyChinh")]
    public partial class TuyChinh
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public double? VanBanLeTrai { get; set; }

        public double? VanBanLeTren { get; set; }

        public double? DsnLeTrai { get; set; }

        public double? DsnLeTren { get; set; }

        public double? DsnDanDong { get; set; }

        public double? DauChimRong { get; set; }

        public double? DauChimCao { get; set; }

        public double? DauChimFont { get; set; }

        public double? DauChimOpacity { get; set; }

        public double? DauChimMauDoc { get; set; }

        public double? DauChimMauPdf { get; set; }

        public double? VungCkRong { get; set; }

        public double? VungCkCao { get; set; }

        public double? VungCkLeDuoi { get; set; }

        public double? AnhCkRong1 { get; set; }

        public double? AnhCkCao1 { get; set; }

        public double? AnhCkCao2 { get; set; }

        public double? AnhCkRong2 { get; set; }

        [StringLength(256)]
        public string TieuDe { get; set; }

        [StringLength(50)]
        public string In2Mat { get; set; }

        [StringLength(50)]
        public string KhayGiay { get; set; }

        [StringLength(50)]
        public string Dien { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        public bool? InDauMatLenDien { get; set; }

        [StringLength(50)]
        public string CoSo { get; set; }

        [StringLength(256)]
        public string LuuFile { get; set; }
    }
}
