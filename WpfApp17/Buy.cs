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
    
    public partial class Buy
    {
        public int ID_Buy { get; set; }
        public System.DateTime Buy_Date { get; set; }
        public string Buy_Plus { get; set; }
        public string Buy_Money { get; set; }
        public int Users_Buy_ID { get; set; }
        public int Contractor_ID { get; set; }
        public int Request_ID { get; set; }
    
        public virtual Contractor Contractor { get; set; }
        public virtual Request Request { get; set; }
        public virtual Users Users { get; set; }
    }
}
