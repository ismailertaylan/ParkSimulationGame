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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buton1e tıklandığında bu form kapansın, gerekli form açılsın.
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buton2ye tıklandığında bu form kapansın, gerekli form açılsın.
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}