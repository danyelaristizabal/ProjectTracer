//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectTracer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public int Task_Id { get; set; }
        public string Project_Id { get; set; }
        public string Developer_Id { get; set; }
        public string Description { get; set; }
        public System.DateTime DeadLine { get; set; }
    
        public virtual Developers Developers { get; set; }
        public virtual Projects Projects { get; set; }
    }
}
