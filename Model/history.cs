//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LabProj.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class history
    {
        public int history_id { get; set; }
        public int service_id { get; set; }
        public int user_id { get; set; }
        public int work_id { get; set; }
        public System.DateTime start_date { get; set; }
        public System.DateTime end_date { get; set; }
        public int duration { get; set; }
        public int analyzer_id { get; set; }
        public string status { get; set; }
    
        public virtual analyzer analyzer { get; set; }
        public virtual service service { get; set; }
        public virtual user user { get; set; }
    }
}
