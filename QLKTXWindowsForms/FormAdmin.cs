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
    public partial class FormAdmin : Form
    {
        QLKTXEntities db = new QLKTXEntities();
        private int idAdmin;
        public FormAdmin(int id)
        {
            idAdmin = id;
            InitializeComponent();
            loadata();
        }
        private void loadata()
        {
            var User = db.Admins.Find(idAdmin);
            try
            {
                textBox1.Text = User.FullName;
                textBox2.Text = User.Address;
                textBox3.Text = User.PhoneNumber;
                textBox4.Text = User.Email;
            }
            catch
            {
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Lưu")
            {
                try
                {
                    string Address = textBox2.Text;
                    string FullName = textBox1.Text;
                    string PhoneNumber = textBox3.Text;
                    string Email = textBox4.Text;
                    var User = db.Admins.Find(idAdmin);
                    User.FullName = FullName;
                    User.PhoneNumber = PhoneNumber;
                    User.Email = Email;
                    User.Address = Address;
                    db.SaveChanges();

                    button1.Text = "Cập nhật";
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    textBox1.Enabled = false;
                }
                catch
                {
                    MessageBox.Show("Lỗi server", "Thông báo");
                }
            }
            else if (button1.Text == "Cập nhật")
            {
                button1.Text = "Lưu";
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox1.Enabled = true;
                textBox2.Focus();
            }
            else
            {
                MessageBox.Show("Lỗi server", "Thông báo");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormChangePassWord formChangePassWord = new FormChangePassWord(idAdmin);
            formChangePassWord.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
