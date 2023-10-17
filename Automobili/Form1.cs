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
                label1.Text = "Accesa";
            }
            else
            {
                button1.BackColor = Color.Red;
                label1.Text = "Spenta";
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > 5)
            {
                MessageBox.Show("Dato inserito non valido");
            }
            else
            {
                auto.Marcia = int.Parse(textBox1.Text);
                if (auto.Marcia == 1) 
                {
                    button6.BackColor = Color.Gray;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                }
                if (auto.Marcia == 2)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.Gray;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                }
                if (auto.Marcia == 3)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.Gray;
                }
                if (auto.Marcia == 4)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.Gray;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                }
                if (auto.Marcia == 5)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.White;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.Gray;
                    button7.BackColor = Color.White;
                }
                if (auto.Marcia == 0)
                {
                    button6.BackColor = Color.White;
                    button5.BackColor = Color.Gray;
                    button4.BackColor = Color.White;
                    button3.BackColor = Color.White;
                    button8.BackColor = Color.White;
                    button7.BackColor = Color.White;
                }
            }
            
        }
    }
}
