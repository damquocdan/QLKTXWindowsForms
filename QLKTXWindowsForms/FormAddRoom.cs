using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QLKTXWindowsForms
{
    public partial class FormAddRoom : Form
    {
        QLKTXEntities db = new QLKTXEntities(); 
        public FormAddRoom()
        {
            InitializeComponent();
        }
        public int StringToInt(string str)
        {
            if (int.TryParse(str, out int output))
            {
                return output;
            }
           
            return 0;
        }
        private void buttonRegester_Click(object sender, EventArgs e)
        {
            string Mowroom = comboBox2.Text;
            string Building = textBoxToa.Text;
            int Floor = StringToInt(textBoxTang.Text);
            int Numberroom = StringToInt(textBoxSoPhong.Text);
            string Bednumber = textBoxSoGiuong.Text;
            int Numberofstudent = 0;
            int Status = 0;
            if (Mowroom.Equals("") || Building.Equals("") || Floor <= 0 || Numberroom <= 0)
            {
                MessageBox.Show("Hãy nhập thông tin của bạn!", "Thông báo");
                return;
            }
            
                /*
            var query = db.Students.Where(a => a.StudentCode == studentcode);
            if (query.Count() > 0)
            {
                MessageBox.Show("Mã sinh viên đã sử dụng!", "Thông báo");
            }
            else
            {
                Student newAccount = new Student()
                {
                    StudentCode = studentcode,
                    Password = password,
                    FirstName = firstname,
                    LastName = lastname,
                    Gender = gender,
                    PhoneNumber = phone,
                    Email = email,
                    Department = deparment,
                    ParentPhoneNumber = phoneparent,
                    DH = DH,
                };

                db.Students.Add(newAccount);
                Console.WriteLine(newAccount);
                db.SaveChanges();


                MessageBox.Show("Đăng ký tài khoản thành công, hãy chờ cấp quyền truy cập!", "Thông báo");
                this.Close();
            }
           
            */
        }
    }
}
