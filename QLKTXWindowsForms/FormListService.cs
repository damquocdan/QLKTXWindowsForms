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
    public partial class FormListService : Form
    {
        QLKTXEntities db = new QLKTXEntities();
        public FormListService()
        {
            InitializeComponent();
        }
        private void LoadDataRoom()
        {
            var listService = from c in db.Services

                           select new { c.ServiceID, c.ServiceName, c.Month, c.Price, c.Room.NumberRoom, c.Status};

            dgvDSMH.DataSource = listService.ToList();


            db.SaveChanges();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            CbDichvu.Text = "";
            btnSua.Text = "Cập nhật";
            LoadDataRoom();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int Numberroom;
            string Servicename = CbDichvu.Text;
            if (!int.TryParse(txtTimKiem.Text, out Numberroom))
            {
                // Nếu không thành công, gán giá trị mặc định cho numberRoom
                Numberroom = 0;
            }
            var service = from c in db.Services

                       select new { c.ServiceID, c.ServiceName, c.Month, c.Price, c.Room.NumberRoom, c.Status };
            if (Numberroom != 0)
            {
                service = service.Where(c => c.NumberRoom == Numberroom);
            }

            if (Servicename != "")
            {
                service = service.Where(c => c.ServiceName.Contains(Servicename));
            }
            dgvDSMH.DataSource = service.ToList();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDSMH.SelectedRows.Count > 0)
            {

                try
                {
                    int[] arrId = new int[dgvDSMH.SelectedRows.Count];
                    int i = 0;
                    foreach (DataGridViewRow row in dgvDSMH.SelectedRows)
                    {
                        arrId[i] = int.Parse(row.Cells[0].Value.ToString());
                        i++;
                    }
                    var deleteAccount = db.Services.Where(u => arrId.Contains(u.ServiceID));
                    if (deleteAccount != null)
                    {
                        string message = "Bạn có chắc chắn muốn xóa phòng này hay không?";

                        DialogResult result = MessageBox.Show(message, "Xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string text = "Phòng trên đã xoá thành công!";
                            db.Services.RemoveRange(deleteAccount);
                            db.SaveChanges();
                            MessageBox.Show(text);
                            LoadDataRoom();
                        }
                    }
                    else
                    {
                        string text = "Không tìm thấy phòng cần xoá";
                        MessageBox.Show(text);
                    }

                }
                catch { string text = "Lỗi server"; MessageBox.Show(text); }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }
    }
}
