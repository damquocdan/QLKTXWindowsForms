﻿using System;
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
        public FormListRoom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            CbMOV.Text = "";
            btnSua.Text = "Cập nhật";
            LoadDataRoom();
        }
    }
}