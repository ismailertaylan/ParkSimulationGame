using System;
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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buton1e tıklandığında bu form kapansın, gerekli form açılsın.
            Form10 form10 = new Form10();
            form10.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buton2ye tıklandığında bu form kapansın, gerekli form açılsın.
            Form11 form11 = new Form11();
            form11.Show();
            this.Hide();
        }
    }
}
