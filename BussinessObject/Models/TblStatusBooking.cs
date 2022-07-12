using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class TblStatusBooking
    {
        public TblStatusBooking()
        {
            TblBookings = new HashSet<TblBooking>();
        }

        public string StatusName { get; set; }

        public virtual ICollection<TblBooking> TblBookings { get; set; }
    }
}
