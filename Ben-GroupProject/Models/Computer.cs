//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ben_GroupProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Computer
    {
        public int Id { get; set; }
        public string type { get; set; }
        public bool availability { get; set; }
        public int lab { get; set; }
    
        public virtual Lab Lab1 { get; set; }
    }
}
