using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QLKTXWindowsForms
{
    public partial class Form1 : Form
    {
        QLKTXEntities db = new QLKTXEntities();
        public Form1()
        {
            InitializeComponent();
        }
        private void FormLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Xử lý sự kiện Enter tại đây, chẳng hạn gọi hàm kiểm tra đăng nhập.
                buttonLogin_Click(sender, e);
            }
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxEmail.Text;
            string password = textBoxPassword.Text;
            if (username.Length > 0 && password.Length > 0)
            {
                var query = db.Admins.Where(a => a.Email == username && a.Password == password).FirstOrDefault();
                if (query != null)
                {
                    this.Hide();
                    AdminMainForm st = new AdminMainForm(query.AdminID);
                    st.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Hãy nhập tên tài khoản và mật khẩu!", "Thông báo");
            }
        }
    }
}
