using System;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace QLKTXWindowsForms
{
    public partial class FormOccupancy : Form
    {
        QLKTXEntities db = new QLKTXEntities();
        private int checkStatus = -1;
        public FormOccupancy()
        {
            InitializeComponent();
            LoadHopDong();
        }
        public void LoadHopDong()
        {
            var listHopDong = from c in db.Occupancies
                              select new { c.OccupancyID, c.Student.StudentCode, c.Room.NumberRoom,c.RenewalDate, c.ExpirationDate,c.CycleMonths,c.Status };
            dgvHopDong.DataSource = listHopDong.ToList();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            textBoxMaSinhVien.Text = "";
            textBoxMaPhong.Text = "";
            textBoxHanPhong.Text = "";
            LoadHopDong();
            checkBoxStatus.Checked = false;
            checkStatus = -1;
        }
        private void checkBoxStatus_CheckedChanged(object sender, EventArgs e)
        {
            checkStatus = 0;

            if (checkBoxStatus.Checked)
            {
                checkStatus = 1;
            }
            
        }
        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            int id = SystemQLKT.StringToInt(txtID.Text);
            string maSv = textBoxMaSinhVien.Text;
            int maPhong = SystemQLKT.StringToInt(textBoxMaPhong.Text);
            int hanphong = SystemQLKT.StringToInt(textBoxHanPhong.Text);

            var listHD = from c in db.Occupancies select c;

            if (id != 0)
            {
                listHD = listHD.Where(c => c.OccupancyID == id);
            }
            if (!maSv.Equals(""))
            {
                listHD = listHD.Where(c => c.Student.StudentCode.Contains(maSv));
            }
            if (maPhong != 0)
            {
                listHD = listHD.Where(c => c.RoomID == maPhong);
            }

            if (hanphong != 0)
            {
                DateTime ngaySoSanh = DateTime.Today.AddDays(hanphong * 30);
                listHD = listHD.Where(c => c.ExpirationDate >= DateTime.Today && c.ExpirationDate < ngaySoSanh);
            }
            if (checkStatus == 1 || checkStatus == 0)
            {
                bool result = (checkStatus != 0);
                listHD = listHD.Where(c => c.Status == result);
            }

            var hd = from c in listHD
                     select new
                     {
                         c.OccupancyID,
                         c.Student.StudentCode,
                         c.Room.NumberRoom,
                         c.RenewalDate,
                         c.ExpirationDate,
                         c.CycleMonths,
                         c.Status
                     };

            dgvHopDong.DataSource = hd.ToList();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string text = label1.Text;
            ExportExcel.DataToExcel(dgvHopDong, text);
        }

        private void buttonNotifixcation_Click(object sender, EventArgs e)
        {
            string email = "21111064572@hunre.edu.vn";
            string passwork = "Danli29.03";
            string subject = "Ký túc xá trường đại học tài nguyên và môi trường";
            foreach (DataGridViewRow row in dgvHopDong.Rows)
            {
                string studentCode = row.Cells[1].Value.ToString();
                var listName = (from c in db.Students
                              where c.StudentCode.Equals(studentCode)
                              select c).FirstOrDefault();
                string name = !string.IsNullOrEmpty(listName.FullName) ? listName.FullName : studentCode;
                string htmlBody = "<div>" +
                                    "<h2>Dear "+ name + "!</h2>" +
                                    "<p>Mời bạn vào trang web ký túc xá để gia hạn phòng!</p>" +
                                    "<a href=\"#\">Nhấp vào đây để tới trang web</a>" +
                               "</div>";
                string toEmail = studentCode + "@hunre.edu.vn";
                SystemQLKT.SendEmail(email, passwork, toEmail, subject, htmlBody);
            }
            MessageBox.Show("Gửi email thông báo thành công!", "Thông báo");
        }
    }
}
