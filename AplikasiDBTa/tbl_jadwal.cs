//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AplikasiDBTa
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_jadwal
    {
        public int id_Ta { get; set; }
        public System.DateTime Hari { get; set; }
        public System.TimeSpan Waktu { get; set; }
        public string Sidang { get; set; }
        public string Ruangan { get; set; }
    
        public virtual tbl_Ta tbl_Ta { get; set; }
    }
}
