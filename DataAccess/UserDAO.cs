using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
namespace DataAccess
{
    public class UserDAO
    {
        public static List<TblUser> GetMembers()
        {
            var listMember = new List<TblUser>();
            try
            {
                using (var db = new FPT_Mentor_AppointmentContext())
                {
                    listMember = db.TblUsers.ToList();
                }
            }
            catch (Exception ex) { }
            return listMember;
        }
    }
}
