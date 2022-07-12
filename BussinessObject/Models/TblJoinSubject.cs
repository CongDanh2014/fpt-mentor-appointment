using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class TblJoinSubject
    {
        public int SubjectId { get; set; }
        public string Accepter { get; set; }

        public virtual TblUser AccepterNavigation { get; set; }
        public virtual TblSubject Subject { get; set; }
    }
}
