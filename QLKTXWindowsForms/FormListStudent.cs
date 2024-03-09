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
    public partial class FormListStudent : Form
    {
        QLKTXEntities db = new QLKTXEntities();
        public FormListStudent()
        {
            InitializeComponent();
        }
        private void LoadDataAccount()
        {
            var loadStudent = from c in db.Students
                              select new
                              {
                                  c.StudentID,
                                  c.StudentCode,
                                  c.FullName,
                                  c.Email,
                                  c.PhoneNumber,
                                  c.DateOfBirth,
                                  c.Gender,
                                  c.DH.DHCode,
                                  c.Department.DepartmentName,
                                  c.Class,
                                  c.ParentPhoneNumber,
                                  c.AdmissionConfirmation,
                                  c.BedID,
                                  c.RoomID
                              };
            dgvAccount.DataSource = loadStudent.ToList();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            textBox1.Text = "";
            LoadDataAccount();
        }

        private void btnTraCuu_Click(object sender, EventArgs e)
        {
            int Id = 0;
            try
            {
                Id = int.Parse(txtID.Text);
            }
            catch
            { }

            var listAccount = from c in db.Students
                              select new
                              {
                                  c.StudentID,
                                  c.StudentCode,
                                  c.FullName,
                                  c.Email,
                                  c.PhoneNumber,
                                  c.DateOfBirth,
                                  c.Gender,
                                  c.DHID,
                                  c.DepartmentID,
                                  c.Class,
                                  c.ParentPhoneNumber,
                                  c.AdmissionConfirmation,
                                  c.BedID,
                                  c.RoomID
                              };


            string fullName = textBox1.Text;


            if (Id != 0)
            {
                listAccount = listAccount.Where(c => c.StudentID == Id);
            }
            if (fullName != "")
            {
                listAccount = listAccount.Where(c => c.FullName.Contains(fullName));
            }

            dgvAccount.DataSource = listAccount.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormRegesterStudent formRegester = new FormRegesterStudent();
            formRegester.ShowDialog();
            LoadDataAccount();
        }


        private void FormListStudent_Load(object sender, EventArgs e)
        {
            LoadDataAccount();
        }
    }
}
