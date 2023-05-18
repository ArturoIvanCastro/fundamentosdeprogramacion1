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

namespace wpfmatrices_calculos
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
        int[,] mat1;
        int[,] mat2;
        int[,] mat3;
        double[,] mat4;
        private void GENERAR_DATOS_Click(object sender, RoutedEventArgs e)
        { 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
                mat3 = new int[5,5];
            matriz3.Children.Clear();

            for (int r=0; r < 5; r++ )
            {
                for(int  c = 0; c < 5; c++)
                {
                    mat3[r,c] = mat1[r,c] + mat2[r,c];
                    Label lbl3 = new Label();
                    lbl3.Content = mat3[r, c];
                    Grid.SetColumn(lbl3 , c);
                    Grid.SetRow(lbl3, r);
                    matriz3.Children.Add(lbl3);
                }
            }    
        }

        private void GENERAR_DATOS_Click_1(object sender, RoutedEventArgs e)
        {
            mat1 = new int[5, 5];
            mat2 = new int[5, 5];
            Random num = new Random();
            matriz1.Children.Clear();
            matriz2.Children.Clear();
            matriz3.Children.Clear();
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    mat1[r, c] = num.Next(1, 10);
                    mat2[r, c] = num.Next(1, 10);
                    Label lbl1 = new Label();
                    lbl1.Content = mat1[r, c];
                    Grid.SetColumn(lbl1, c);
                    Grid.SetRow(lbl1, r);
                    matriz1.Children.Add(lbl1);

                    Label lbl2 = new Label();
                    lbl2.Content = mat2[r, c];
                    Grid.SetColumn(lbl2, c);
                    Grid.SetRow(lbl2, r);
                    matriz2.Children.Add(lbl2);
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mat3 = new int[5, 5];
            matriz3.Children.Clear();

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    mat3[r, c] = mat1[r, c] - mat2[r, c];
                    Label lbl3 = new Label();
                    lbl3.Content = mat3[r, c];
                    Grid.SetColumn(lbl3, c);
                    Grid.SetRow(lbl3, r);
                    matriz3.Children.Add(lbl3);
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mat3 = new int[5, 5];
            matriz3.Children.Clear();

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    mat3[r, c] = mat1[r, c] * mat2[r, c];
                    Label lbl3 = new Label();
                    lbl3.Content = mat3[r, c];
                    Grid.SetColumn(lbl3, c);
                    Grid.SetRow(lbl3, r);
                    matriz3.Children.Add(lbl3);
                }
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mat4 = new double[5, 5];
            matriz3.Children.Clear();

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    mat4[r, c] =(double)mat1[r, c] / (double)mat2[r, c];
                    Label lbl3 = new Label();
                    lbl3.Content = mat4[r, c].ToString("pene.##");
                    Grid.SetColumn(lbl3, c);
                    Grid.SetRow(lbl3, r);
                    matriz3.Children.Add(lbl3);
                }
            }
        }
    }
}