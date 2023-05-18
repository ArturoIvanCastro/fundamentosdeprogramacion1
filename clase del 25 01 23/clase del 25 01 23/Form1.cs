using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase_del_25_01_23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte primer_valor;
            int segundo_valor;
            byte tercer_valor;
            decimal resultado;
            //MaxLenghet sirve para limitar los digitos y/o caracteres
            if (int.Parse(textBox1.Text) < 0 || int.Parse(textBox1.Text) > 255)
                MessageBox.Show("este valor no me sirve, uno del 0 al 255, esos si sirven");
            else
            {
                if (double.Parse(textBox2.Text) < -2147483648 || double.Parse(textBox2.Text) > 2147483647)
                    MessageBox.Show("ese valor como que no da, la verdad");
                else
                {
                  
                    if (int.Parse(textBox4.Text) < 0 || int.Parse(textBox4.Text) > 255)
                        MessageBox.Show("este valor no me sirve, uno del 0 al 255, esos si sirven");
                    else
                    {
                        primer_valor = Convert.ToByte(textBox1.Text);
                        segundo_valor = Convert.ToInt32(textBox2.Text);
                        tercer_valor = Convert.ToByte(textBox4.Text);
                        resultado = primer_valor + segundo_valor + tercer_valor;
                        textBox3.Text = resultado.ToString();
                    }
                
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
