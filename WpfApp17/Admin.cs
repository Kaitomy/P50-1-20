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
    
    public partial class Admin
    {
        public string Klient_Nickname { get; set; }
        public int Users_Admin_ID { get; set; }
    
        public virtual Users Users { get; set; }
    }
}
