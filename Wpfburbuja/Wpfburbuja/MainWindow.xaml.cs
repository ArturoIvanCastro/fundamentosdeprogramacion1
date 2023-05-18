using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Wpfburbuja
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
        private int [,] mat1;
        private int [,] mat2;
        private int [] arreglo;
    
        private void btncargar_Click(object sender, RoutedEventArgs e)
        {
            Random num = new Random();
            mat1 = new int[5, 5];
            arreglo = new int[25];
            grid1.Children.Clear();
            grid2.Children.Clear();
            for (int r =0; r < 5; r++)
            {
                for(int c=0; c < 5; c++)
                {
                    mat1[r, c] = num.Next(1,100);
                    Label lbl = new Label();
                    lbl.Content = mat1[r, c];
                    Grid.SetColumn(lbl, c);
                    Grid.SetRow(lbl, r);
                    grid1.Children.Add(lbl);
                }
            }
        }
        int contador = 0;
        private void burbuja()
        {
            

            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    arreglo[contador] = mat1[r, c];
                    contador++;

                }
            }
        }
        private void ordenamientoporseleccion()
        {
            int n = arreglo.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arreglo[j] < arreglo[minIndex])
                    {
                        minIndex = j;
                    }
                }
                if (minIndex != i)
                {
                    int temp = arreglo[i];
                    arreglo[i] = arreglo[minIndex];
                    arreglo[minIndex] = temp;
                }
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    
         private void ordenamientoporinsercion()
         {
            int n = arreglo.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arreglo[i];
                int j = i - 1;
                while (j >= 0 && arreglo[j] > key)
                {
                    arreglo[j + 1] = arreglo[j];
                    j--;
                }
                arreglo[j + 1] = key;

            }
         }
        private void ordenamientoporshell()
        {
            int n = arreglo.Length;
            int intervalo = 1;
            while (intervalo < n / 3)
            {
                intervalo = intervalo * 3 + 1;
            }
            while (intervalo >= 1)
            {
                for (int i = intervalo; i < n; i++)
                {
                    int key = arreglo[i];
                    int j = i - intervalo;
                    while (j >= 0 && arreglo[j] > key)
                    {
                        arreglo[j + intervalo] = arreglo[j];
                        j -= intervalo;
                    }
                    arreglo[j + intervalo] = key;
                }
                intervalo /= 3;

            }
        }
        private void ordenamientopormezcla()
        {

            MergeSort(arreglo);
        }
        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            MergeSortHelper(arr, temp, 0, n - 1);
        }

        private static void MergeSortHelper(int[] arr, int[] temp, int left, int right)
        {
            if (left < right)
            {
                int mid = (left + right) / 2;
                MergeSortHelper(arr, temp, left, mid);
                MergeSortHelper(arr, temp, mid + 1, right);
                Merge(arr, temp, left, mid, right);
            }
        }

        private static void Merge(int[] arr, int[] temp, int left, int mid, int right)
        {
            int i = left;
            int j = mid + 1;
            int k = left;

            while (i <= mid && j <= right)
            {
                if (arr[i] <= arr[j])
                {
                    temp[k] = arr[i];
                    i++;
                }
                else
                {
                    temp[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                temp[k] = arr[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                temp[k] = arr[j];
                j++;
                k++;
            }

            for (k = left; k <= right; k++)
            {
                arr[k] = temp[k];
            }
        }
        private void ordenamientoporrapido()
        {

            QuickSort(arreglo);
        }
        public static void QuickSort(int[] arr)
        {
            QuickSortHelper(arr, 0, arr.Length - 1);
        }

        private static void QuickSortHelper(int[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                QuickSortHelper(arr, left, pivotIndex - 1);
                QuickSortHelper(arr, pivotIndex + 1, right);
            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            int pivot = arr[right];
            int i = left - 1;

            for (int j = left; j <= right - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, right);
            return i + 1;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    
        private void visualizamatrizordenada()
        {
            mat2 = new int[5, 5];

            for (int i = 0; i < 25; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        int temp = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = temp;
                    }
                }
            }
            int contador2 = 0;
            for (int r = 0; r < 5; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    mat2[r, c] = arreglo[contador2];
                    Label lbl = new Label();
                    lbl.Content = mat2[r, c];
                    Grid.SetColumn(lbl, c);
                    Grid.SetRow(lbl, r);
                    grid2.Children.Add(lbl);
                    contador2++;
                }
            }

        }
        private void btnburbuja_Click(object sender, RoutedEventArgs e)
        {
            burbuja();
            visualizamatrizordenada();
        }

        private void btnseleccion(object sender, RoutedEventArgs e)
        {
            ordenamientoporseleccion();
            visualizamatrizordenada();
        }

        private void btninsercion_Click(object sender, RoutedEventArgs e)
        {
            ordenamientoporinsercion();
            visualizamatrizordenada();
        }

        private void btnshell_Click(object sender, RoutedEventArgs e)
        {
            ordenamientoporshell();
            visualizamatrizordenada();
        }

        private void btnmezcla_Click(object sender, RoutedEventArgs e)
        {
            ordenamientopormezcla();
            visualizamatrizordenada();
        }

        private void btnrapido_Click(object sender, RoutedEventArgs e)
        {
            ordenamientoporrapido();
            visualizamatrizordenada();
        }
    }
}
