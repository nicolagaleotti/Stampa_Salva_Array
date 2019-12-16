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
        int maxSize = 10000;
        int maxValue = 1000;
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
                int[] array = new int[valore];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = rnd.Next(1, maxValue);
                }
                lblResult.Content = "[";
                for (int i = 0; i < array.Length; i++)
                {
                    lblResult.Content = lblResult.Content + $"{array[i]}";
                    if ( i < array.Length - 1)
                        lblResult.Content += ",";
                }
                lblResult.Content += "]";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtValore.Text = "";
            }
        }

        private void TxtValore_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int valore = int.Parse(txtValore.Text);
                if (valore <= 0 || valore > maxSize)
                {
                    btnGenera.IsEnabled = false;
                    txtValore.Foreground = Brushes.Red;
                }
                else
                {
                    txtValore.Foreground = Brushes.Black;
                    btnGenera.IsEnabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
