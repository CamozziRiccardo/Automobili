using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobili
{
    public partial class Form1 : Form
    {
        Auto_Man auto;

        public Form1()
        {
            InitializeComponent();
            auto = new Auto_Man();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (auto.Accensione())
            {
                button1.BackColor = Color.Green;
            }
            else
            {
                button1.BackColor = Color.Red;
            }
        }
    }
}
