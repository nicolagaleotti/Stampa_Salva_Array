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

namespace Array
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
        Random rnd = new Random();
        private void btnGenera_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int valore = int.Parse(txtValore.Text);
                if (valore <= 0)
                    throw new Exception("Il numero deve essere maggiore di 0!");
                int[] array = new int[valore];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next();
                }
                lblResult.Content = "[";
                for (int i = 0; i < array.Length; i++)
                {
                    lblResult.Content = lblResult.Content + $"{array[i]}";
                    if ( i < array.Length - 1)
                        lblResult.Content += ",";
                }
                lblResult.Content += "]";
                string file = @"stato.txt";
                file = System.IO.StreamWriter(lblResult.Content);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtValore.Text = "";
            }
        }
    }
}
