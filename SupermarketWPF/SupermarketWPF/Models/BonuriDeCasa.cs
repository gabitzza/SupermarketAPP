//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SupermarketWPF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BonuriDeCasa
    {
        public DateTime Data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BonuriDeCasa()
        {
            this.BonuriDeCasa_Produse = new HashSet<BonuriDeCasa_Produse>();
        }
    
        public int Id { get; set; }
        public System.DateTime DataEliberarii { get; set; }
        public Nullable<int> CasierId { get; set; }
        public decimal SumaIncasata { get; set; }
        public Nullable<bool> IsActive { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BonuriDeCasa_Produse> BonuriDeCasa_Produse { get; set; }
        public virtual Utilizatori Utilizatori { get; set; }
    }
}
