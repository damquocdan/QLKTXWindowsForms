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
    public partial class FormListRoom : Form
    {
        private int IdRoom = 0;
        QLKTXEntities db= new QLKTXEntities();
        private int[] ArrNumberRoom = new int[100];
        public FormListRoom()
        {
            InitializeComponent();
            LoadDataRoom();
        }
        private void LoadDataRoom()
        {
            var listRoom = from c in db.Rooms

                           select new { c.RoomID, c.MOWRoom, c.Building, c.Floor, c.NumberRoom, c.BedNumber, c.NumberOfStudents, c.Status };

            dgvDSMH.DataSource = listRoom.ToList();


            db.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            txtTimKiem.Text= "";
            CbMOWRoom.Text = "";

            btnSua.Text = "Cập nhật";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int NumberRoom;
            string MowRoom = CbMOWRoom.Text;
            if (!int.TryParse(txtTimKiem.Text, out NumberRoom))
            {
                // Nếu không thành công, gán giá trị mặc định cho numberRoom
                NumberRoom = 0;
            }
            var room = from c in db.Rooms

                       select new { c.RoomID, c.MOWRoom, c.Building, c.Floor, c.NumberRoom, c.BedNumber, c.NumberOfStudents, c.Status };
            if (NumberRoom != 0)
            {
                room = room.Where(c => c.NumberRoom == NumberRoom);
            }

            if (MowRoom != "")
            {
                room = room.Where(c => c.MOWRoom.Contains(MowRoom));
            }
            dgvDSMH.DataSource = room.ToList();
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
                    var deleteAccount = db.Rooms.Where(u => arrId.Contains(u.RoomID));
                    if (deleteAccount != null)
                    {
                        string message = "Bạn có chắc chắn muốn xóa phòng này hay không?";

                        DialogResult result = MessageBox.Show(message, "Xóa phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            string text = "Phòng trên đã xoá thành công!";
                            db.Rooms.RemoveRange(deleteAccount);
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
            try
            {
                if (btnSua.Text == "Cập nhật")
                {
                    IdRoom = int.Parse(dgvDSMH.SelectedRows[0].Cells[0].Value.ToString());
                    txtTimKiem.Text = dgvDSMH.SelectedRows[0].Cells[4].Value.ToString();
                    CbMOWRoom.Text = dgvDSMH.SelectedRows[0].Cells[1].Value.ToString();
                    btnSua.Text = "Lưu lại";
                }
                else if (btnSua.Text == "Lưu lại")
                {
                    if (txtTimKiem.Text != "" && CbMOWRoom.Text != "")
                    {
                        var listRoom = db.Rooms.Where(c => c.MOWRoom == CbMOWRoom.Text && c.NumberRoom == int.Parse(txtTimKiem.Text));
                        if (listRoom.Count() > 0)
                        {
                            string text = "Phòng đã tồn tại!";
                            MessageBox.Show(text);
                        }
                        else
                        {
                            var updateRoom = db.Rooms.Find(IdRoom);
                            updateRoom.MOWRoom = CbMOWRoom.Text;
                            updateRoom.NumberRoom = ArrNumberRoom[int.Parse(txtTimKiem.Text)];
                            db.SaveChanges();
                            string text = "Phòng: " + txtTimKiem.Text + " đã được cập nhật!";
                            MessageBox.Show(text);

                            txtTimKiem.Text = "";
                            CbMOWRoom.Text = "";
                            btnSua.Text = "Cập nhật";
                            IdRoom = 0;
                            LoadDataRoom();
                        }
                    }
                    else
                    {
                        string text = "Không tìm thấy phòng cần cập nhật";
                        MessageBox.Show(text);
                    }
                }
            }
            catch
            {
                string text = "Lỗi server";
                MessageBox.Show(text);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            FormAddRoom formAddRoom = new FormAddRoom();
            formAddRoom.ShowDialog();
            LoadDataRoom();
        }
    }
}
