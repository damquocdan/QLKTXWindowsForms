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
            int Bednumber = StringToInt(textBoxSoGiuong.Text);
            int Numberofstudent = 0;
            int Status = 0;
            if (Mowroom.Equals("") || Building.Equals("") || Floor <= 0 || Numberroom <= 0)
            {
                MessageBox.Show("Hãy nhập thông tin của bạn!", "Thông báo");
                return;
            }
            
            
            var query = db.Rooms.Where(a => a.NumberRoom == Numberroom || a.Building ==Building);
            if (query.Count() > 0)
            {
                MessageBox.Show("Phòng đã có!", "Thông báo");
            }
            else
            {
                Room newRoom = new Room()
                {
                    MOWRoom = Mowroom,
                    Building = Building,
                    Floor = Floor,
                    NumberRoom = Numberroom,
                    BedNumber = Bednumber,
                    NumberOfStudents = 0,
                };

                db.Rooms.Add(newRoom);
                Console.WriteLine(newRoom);
                db.SaveChanges();


                MessageBox.Show("Tạo phòng thành công", "Thông báo");
                this.Close();
            }
           
        }
    }
}
