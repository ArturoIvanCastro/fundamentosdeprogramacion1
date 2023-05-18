using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_del_07_02_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mes;
            if (int.Parse(textBox1.Text) < 1 || int.Parse(textBox1.Text) > 12)
                MessageBox.Show("un numero del 1 al 12");

            else
            {
                if (int.Parse(textBox1.Text) <= 3)
                MessageBox.Show("es invierno");
                else 
                {
                    if (int.Parse(textBox1.Text) <= 4 || int.Parse(textBox1.Text) <= 6)
                        MessageBox.Show("es primavera");
                    else
                    {
                        if (int.Parse(textBox1.Text) <= 7 || int.Parse(textBox1.Text) <= 8)
                            MessageBox.Show("es verano");
                        else
                        {
                            if (int.Parse(textBox1.Text) <= 9 || int.Parse(textBox1.Text) <= 12)
                                MessageBox.Show("es otoño");
                        }
                    }
                }
            } 
        }
    }
}
