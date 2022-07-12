using BussinessObject.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SalesWithApp
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        void LoadUserList()
        {
            FPT_Mentor_AppointmentContext db = new FPT_Mentor_AppointmentContext();
            var result = from u in db.TblUsers select u;
            dgvListUser.DataSource = result.ToList();
        }
        private void frmAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
