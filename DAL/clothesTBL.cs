//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class clothesTBL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public clothesTBL()
        {
            this.shopingDetailsTBL = new HashSet<shopingDetailsTBL>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public Nullable<int> category_id { get; set; }
        public Nullable<decimal> price { get; set; }
        public string img { get; set; }
        public string color { get; set; }
        public Nullable<int> size { get; set; }
        public Nullable<int> amount { get; set; }
    
        public virtual categoryTBL categoryTBL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<shopingDetailsTBL> shopingDetailsTBL { get; set; }
    }
}