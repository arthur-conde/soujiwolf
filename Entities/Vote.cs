//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Soujiwolf.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vote
    {
        public long GuildSnowflake { get; set; }
        public long Voter { get; set; }
        public long Voted { get; set; }
        public bool Changed { get; set; }
    }
}
