//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookRoom.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tasks
    {
        public int TasksID { get; set; }
        public Nullable<int> roomID { get; set; }
        public string task { get; set; }
        public string stat { get; set; }
        public string deskcomment { get; set; }
        public string servicecomment { get; set; }
    
        public virtual Rooms Rooms { get; set; }
    }
}