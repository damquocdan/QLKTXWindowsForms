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
    public partial class FormRegesterStudent : Form
    {
        QLKTXEntities db = new QLKTXEntities();
        private List<int> ArrDHID = new List<int>();
        private List<int> ArrDepartmentID = new List<int>();
        public FormRegesterStudent()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string studentcode = textBoxStudentCode.Text;
            string password = textBoxPassword.Text;
            string fullname = textBoxFullName.Text;
            string gender = comboBoxGender.Text;
            DateTime dateOfbirth = dateTimePickerDateOfBirth.Value;

            string phone = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string clas = textBoxClass.Text;
            int SelectedIndexDeparment = comboBoxKhoa.SelectedIndex;
            string phoneparent = textBoxParentPhoneNumber.Text;
            int SelectedIndexDH = comboBoxMaDH.SelectedIndex;
            if (studentcode.Length >= 11 && password.Length >= 6 )
            {
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
                        FullName = fullname,
                        Gender = gender,
                        PhoneNumber = phone,
                        Email = email,
                        ParentPhoneNumber = phoneparent,
                        Class = clas,
                        DHID = ArrDHID[SelectedIndexDH],
                        DateOfBirth = dateOfbirth,
                        DepartmentID=ArrDepartmentID[SelectedIndexDeparment]
                    };

                    db.Students.Add(newAccount);
                    Console.WriteLine(newAccount);
                    db.SaveChanges();


                    MessageBox.Show("Đăng ký tài khoản thành công, hãy chờ cấp quyền truy cập!", "Thông báo");
                    this.Close();
                }
            }
            else if (studentcode.Length < 10 || password.Length < 5)
            {
                MessageBox.Show("Nhập đủ mã sinh viên và mật khẩu phải có ít nhất 6 ký tự!", "Thông báo");
            }
            else
            {
                MessageBox.Show("Hãy nhập thông tin của bạn!", "Thông báo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRegesterStudent_Load(object sender, EventArgs e)
        {
            var queryMaDH = from c in db.DHs
                        select new { idDH = c.DHID, DhCode = c.DHCode};
            foreach (var item in queryMaDH)
            {
                ArrDHID.Add(item.idDH);
                comboBoxMaDH.Items.Add(item.DhCode);
            }

            var queryKhoa = from c in db.Departments
                            select new { c.DepartmentID, c.DepartmentName };

            foreach (var item in queryKhoa)
            {
                ArrDepartmentID.Add(item.DepartmentID);
                comboBoxKhoa.Items.Add(item.DepartmentName);
            }
            comboBoxKhoa.SelectedIndex = 0;
            comboBoxKhoa.SelectedIndex = 0;
        }
    }
}
