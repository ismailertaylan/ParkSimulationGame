﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkSim
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //buton2ye tıklandığında program kapansın.
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buton1e tıklandığında bu form kapansın, gerekli form açılsın.
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }
    }
}
