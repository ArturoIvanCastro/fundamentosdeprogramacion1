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

namespace PRACTICA_21_02_23
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        int[] arreglo = new int[3];
        byte contador = 0; 
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int valor = int.Parse(textbox1.Text);
            arreglo[0] = valor;
            contador++;
            
        }

        private void lista_Click(object sender, RoutedEventArgs e)
        {
            for (int i=0; i < arreglo.Length;i++)
            {
                textbox1.items.add(arreglo[i]);
            }
        }
    }
}
