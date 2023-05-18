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

namespace wpfmatrizseries
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
        private int[,] jenni;

       
        private void griddeseries_Loaded(object sender, RoutedEventArgs e)
        {
            Cargar();
            mostrar();
        }
        public void Cargar()
        {
            jenni = new int[10, 10];
            for (int i = 1; i <=6; i++)
            {
                for (int j = 1; j<=6; j++)
                {
                    if(j % 2==0)
                    {
                        jenni[i,j] = 0;

                    }
                    else
                    {
                        jenni[i,j] = 1;
                    }
                }
            }
        }
        public void mostrar()
        {
            for (int i = 1; i <= 6; i++)
            {
                for (int j = 1; j <= 6; j++)
                {
                   Label mil= new Label();
                    mil.Content = jenni[i, j].ToString();
                    Grid.SetColumn(mil, j-1);
                    Grid.SetRow(mil, i-1);
                    griddeseries.Children.Add(mil);
                }
            }
        }

    }
}
