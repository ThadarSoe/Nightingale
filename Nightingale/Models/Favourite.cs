//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nightingale.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Favourite
    {
        public int FavouriteID { get; set; }
        public int RegisterID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
    
        public virtual Register Register { get; set; }
    }
}