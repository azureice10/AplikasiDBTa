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
    
    public partial class tbl_dosen
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_dosen()
        {
            this.tbl_Ta = new HashSet<tbl_Ta>();
            this.tbl_Ta1 = new HashSet<tbl_Ta>();
            this.tbl_Ta2 = new HashSet<tbl_Ta>();
        }
    
        public string nip { get; set; }
        public string nama { get; set; }
        public string password { get; set; }
        public string email { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ta> tbl_Ta { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ta> tbl_Ta1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_Ta> tbl_Ta2 { get; set; }
    }
}
