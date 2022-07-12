using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class TblBooking
    {
        public int BookingId { get; set; }
        public string Booker { get; set; }
        public string Accepter { get; set; }
        public string BookingTitle { get; set; }
        public string BookingLink { get; set; }
        public string BookingDescription { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime TimeStart { get; set; }
        public string StatusName { get; set; }
        public DateTime Time { get; set; }

        public virtual TblUser AccepterNavigation { get; set; }
        public virtual TblUser BookerNavigation { get; set; }
        public virtual TblStatusBooking StatusNameNavigation { get; set; }
    }
}
