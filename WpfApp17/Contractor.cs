//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApp17
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contractor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Contractor()
        {
            this.Buy = new HashSet<Buy>();
            this.Buy_History = new HashSet<Buy_History>();
        }
    
        public int ID_Contractor { get; set; }
        public string Contractor_Name { get; set; }
        public System.DateTime Contractor_Date { get; set; }
        public string Contractor_Status { get; set; }
        public string Contractor_Desc { get; set; }
        public int Special_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy> Buy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Buy_History> Buy_History { get; set; }
        public virtual Special Special { get; set; }
    }
}
