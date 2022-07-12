using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class TblTimeSubject
    {
        public int? SubjectId { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime Time { get; set; }

        public virtual TblSubject Subject { get; set; }
    }
}
