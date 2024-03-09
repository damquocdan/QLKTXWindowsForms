using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKTXWindowsForms
{
    public partial class FormOccupancy : Form
    {
        QLKTXEntities db = new QLKTXEntities();

        public FormOccupancy()
        {
            InitializeComponent();
            LoadHopDong();
        }
        public void LoadHopDong()
        {
            var listHopDong = from c in db.Occupancies
                              select new { c.OccupancyID, c.Student.FullName, c.Room.NumberRoom,c.RenewalDate, c.ExpirationDate,c.CycleMonths,c.Status };
            dgvHopDong.DataSource = listHopDong.ToList();
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
