using System;
using System.Collections.Generic;

#nullable disable

namespace BussinessObject.Models
{
    public partial class TblSubject
    {
        public TblSubject()
        {
            TblJoinSubjects = new HashSet<TblJoinSubject>();
        }

        public int SubjectId { get; set; }
        public string Key { get; set; }
        public string Subjecter { get; set; }
        public string SubjectTitle { get; set; }
        public string SubjectLink { get; set; }
        public string SubjectDescription { get; set; }
        public DateTime? CreateAt { get; set; }

        public virtual TblUser SubjecterNavigation { get; set; }
        public virtual ICollection<TblJoinSubject> TblJoinSubjects { get; set; }
    }
}
