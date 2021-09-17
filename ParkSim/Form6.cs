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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buton1e tıklandığında bu form kapansın, gerekli form açılsın.
            Form8 form8 = new Form8();
            form8.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //buton2ye tıklandığında bu form kapansın, gerekli form açılsın.
            Form9 form9 = new Form9();
            form9.Show();
            this.Hide();
        }
    }
}
