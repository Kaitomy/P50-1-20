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
    
    public partial class Service_Delivery_Assembly
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service_Delivery_Assembly()
        {
            this.Order = new HashSet<Order>();
        }
    
        public int ID_Service_Delivery_Assembly { get; set; }
        public string Service_Name { get; set; }
        public string Service_Country { get; set; }
        public string Service_Price { get; set; }
        public string Service_Period { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Order { get; set; }
    }
}
