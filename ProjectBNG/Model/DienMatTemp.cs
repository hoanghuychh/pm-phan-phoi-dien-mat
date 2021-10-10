namespace ProjectBNG.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DienMatTemp")]
    public partial class DienMatTemp
    {
        public int id { get; set; }

        public int? MaDienMat { get; set; }
    }
}
