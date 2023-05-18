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

namespace arreglopbidimensional
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
        int[,] miMatriz = new int[,]
           {{1,2,3},
            {4,5,6 },
            {7, 8,9}};
        private void miGrid_Loaded(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < miMatriz.GetLength(0); i++)
            {
                for (int j = 0; j < miMatriz.GetLength(1); j++)
                {
                    Label miLabel = new Label();
                    miLabel.Content = miMatriz[i, j].ToString();
                    Grid.SetRow(miLabel, i);
                    Grid.SetColumn(miLabel, j);
                    miGrid.Children.Add(miLabel);

                }
            }
        }
    }
}
