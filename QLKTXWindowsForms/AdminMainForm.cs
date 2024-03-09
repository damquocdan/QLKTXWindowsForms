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
    public partial class AdminMainForm : Form
    {
        private int idAdmin;
        QLKTXEntities db = new QLKTXEntities();
        public AdminMainForm(int id)
        {
            idAdmin = id;
            InitializeComponent();
            FormMain formMain = new FormMain(idAdmin);
            AddForm(formMain);
        }
        private void AddForm(Form form)
        {
            this.panelMainContent.Controls.Clear();
            form.TopLevel = false;
            form.AutoScroll = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            this.Text = form.Text;
            this.panelMainContent.Controls.Add(form);
            this.Width = form.Width + 10;
            this.Height = form.Height + 50;
            form.Show();
            Screen screen = Screen.FromControl(this);
            int x = (screen.WorkingArea.Width - this.Width) / 2 + screen.WorkingArea.Left;
            int y = (screen.WorkingArea.Height - this.Height) / 2 + screen.WorkingArea.Top;
            this.Location = new Point(x, y);


        }
        private void trangChủToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMain formMain = new FormMain(idAdmin);
            AddForm(formMain);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin user = new FormAdmin(idAdmin);
            AddForm(user);
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListStudent formListStudent = new FormListStudent();
            AddForm(formListStudent);
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListRoom formListRoom = new FormListRoom();
            AddForm(formListRoom);
        }


        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListService formListService = new FormListService();
            AddForm(formListService);

        private void hợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOccupancy formOccupancy = new FormOccupancy();
            AddForm(formOccupancy);

        }
    }
}
