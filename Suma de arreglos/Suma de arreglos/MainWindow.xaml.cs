using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Suma_de_arreglos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] arreglo = new int[5];
        int contador = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (contador <= 4)
            {//int.Parse(textbox1.Text);
                arreglo[contador] = Convert.ToInt32(textbox3.Text);  

                listadatos.Items.Add(arreglo[contador]);
                contador++; //contador = contador + 1;
                textbox3.Clear();
                textbox3.Focus();
                textbox2.Text = suma().ToString();
            }
            else
            {
                MessageBox.Show("solo 5 burra");
            }
        }       
        private int suma()
          
            {
                int sumavalores = 0;
                for( int i = 0; i < arreglo.Length; i++)
                {
                    sumavalores=sumavalores+arreglo[i];
                }
                return (sumavalores);
            }

        
    }
}
