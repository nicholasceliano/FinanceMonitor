//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FinanceMonitor.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ConnectionName
    {
        public ConnectionName()
        {
            this.ConnectionCredentials = new HashSet<ConnectionCredential>();
            this.refConnName_AccountType = new HashSet<refConnName_AccountType>();
        }
    
        public int ID { get; set; }
        public string ConnectionName1 { get; set; }
    
        public virtual ICollection<ConnectionCredential> ConnectionCredentials { get; set; }
        public virtual ICollection<refConnName_AccountType> refConnName_AccountType { get; set; }
    }
}
