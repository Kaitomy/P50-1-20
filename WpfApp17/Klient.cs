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
    
    public partial class Klient
    {
        public string Klient_Last_Name { get; set; }
        public string Klient_Name { get; set; }
        public string Klient_Address { get; set; }
        public System.DateTime Klient_Date { get; set; }
        public string Klient_Middle_Name { get; set; }
        public int Users_Klient_ID { get; set; }
    
        public virtual Users Users { get; set; }
    }
}