using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class TblUser
    {
        public TblUser()
        {
            TblBookingAccepterNavigations = new HashSet<TblBooking>();
            TblBookingBookerNavigations = new HashSet<TblBooking>();
            TblJoinSubjects = new HashSet<TblJoinSubject>();
            TblSubjects = new HashSet<TblSubject>();
        }

        public string Email { get; set; }
        public string Name { get; set; }
        public int? RoleId { get; set; }
        public string Photo { get; set; }
        public DateTime? StartDate { get; set; }
        public byte[] Status { get; set; }

        public virtual TblRole Role { get; set; }
        public virtual ICollection<TblBooking> TblBookingAccepterNavigations { get; set; }
        public virtual ICollection<TblBooking> TblBookingBookerNavigations { get; set; }
        public virtual ICollection<TblJoinSubject> TblJoinSubjects { get; set; }
        public virtual ICollection<TblSubject> TblSubjects { get; set; }
    }
}
