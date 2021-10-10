namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TuyChinhCombobox")]
    public partial class TuyChinhCombobox
    {
        public int id { get; set; }

        [StringLength(50)]
        public string TrangThaiTuyChinh { get; set; }

        [StringLength(50)]
        public string GiayIn { get; set; }
    }
}
