//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ErrorLogs = new HashSet<ErrorLog>();
            this.Orders = new HashSet<Order>();
            this.RecentlyVieweds = new HashSet<RecentlyViewed>();
        }
    
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string EmailId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Nullable<int> CityId { get; set; }
        public Nullable<int> StateId { get; set; }
        public string Zip { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public bool IsActive { get; set; }
        public int RoleId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> LastModifiedBy { get; set; }
    
        public virtual City City { get; set; }
        public virtual Country Country { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ErrorLog> ErrorLogs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RecentlyViewed> RecentlyVieweds { get; set; }
        public virtual State State { get; set; }
        public virtual Role Role { get; set; }
    }
}
