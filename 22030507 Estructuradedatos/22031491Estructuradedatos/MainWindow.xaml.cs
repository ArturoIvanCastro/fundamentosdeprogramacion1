using System;
using System.Collections;
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

namespace _22031491Estructuradedatos
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
        Queue micola = new Queue(5);
        Stack miPila = new Stack(5);
        List milista= new List();
        #region // metodo de AB de las estructuras de datos
        private void push_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(texbox.Text)) MessageBox.Show("ingrese un valor");
            {
                if (miPila.Count == 5)
                {
                    MessageBox.Show("pila llena");
                }
                else
                {
                    miPila.Push(texbox.Text);
                    listarpila();

                }
                texbox.Clear();
                texbox.Focus();
            }
            
        }
        private void pila()
        private void cola()
        {
            if (string.IsNullOrEmpty(texbox.Text)) MessageBox.Show("ingrese un valor");
            {
                if (micola.Count ==5)
                {
                    MessageBox.Show("la cola esta llena");
                }
                else
                {

                }
            }
        }
        private void lista()
        private void arbol()

        private void listarcolas()
        {
            listbox.Items.Clear();
            foreach (var elemento in miPila)
            {
                listbox.Items.Add(elemento.ToString());
            }
        }
        private void listarlistas
        {

        }

        private void pull_Click(object sender, RoutedEventArgs e)
        {
            if (rbpila.IsChecked== true)
            {
                if (miPila.Count == 0) MessageBox.Show("pila vacia");
                else
                {
                    miPila.Pop();
                    listarcolas();
                }
            }
            else if (rbcola.IsChecked== true)
            {
                if (micola.Count == 0) MessageBox.Show("cola vacia");
                else
                {
                    micola.Dequeue();
                    listarcolas();
                }
            }
            
                
            
        }
    }
}
