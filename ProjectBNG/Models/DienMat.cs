//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectBNG.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DienMat
    {
        public int id { get; set; }
        public string MaNoiNhan { get; set; }
        public string TenNoiNhan { get; set; }
        public string Loai { get; set; }
        public int SoBaoMat { get; set; }
        public string GhiChu { get; set; }
        public string LuuFile { get; set; }
        public string FileDinhKem { get; set; }
        public string NoiGui { get; set; }
        public string TrichYeu { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public Nullable<int> DoMat { get; set; }
    }
}
