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

namespace matrizdeserieendiagonal
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
        private int[,] jenni; //arreglo bidimensional
        private void miGrid_Loaded(object sender, RoutedEventArgs e)
        {
            cargar();
            mostrar();

        }
        private void cargar()
        {
            jenni = new int[6, 6];
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0
                    ; c < 6; c++)
                {
                    if (r == c)
                    {
                        jenni[r, c] = 1;
                    }
                }
            }
        }
        private void mostrar()
        {
            for (int r = 0; r < 6; r++)
            {
                for (int c = 0; c < 6; c++)
                {
                    Label mil = new Label();
                    mil.Content = jenni[r, c];
                    Grid.SetColumn(mil,c);
                    Grid.SetRow(mil, r);
                    miGrid.Children.Add(mil);
                }
            }
        }
    }
}
