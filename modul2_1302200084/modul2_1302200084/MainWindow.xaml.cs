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

namespace modul2_1302200084
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

        float x, rumus;
        int perulangan;

        private void simbol1_Click(object sender, RoutedEventArgs e)//angka 1, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "1";
        }

        private void simbol2_Click(object sender, RoutedEventArgs e)//angka 2, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "2";
        }

        private void simbol3_Click(object sender, RoutedEventArgs e)//angka 3, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "3";
        }

        private void simbol4_Click(object sender, RoutedEventArgs e)//angka 4, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "4";
        }

        private void simbol5_Click(object sender, RoutedEventArgs e)//angka 5, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "5";
        }

        private void simbol6_Click(object sender, RoutedEventArgs e)//angka 6, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "6";
        }

        private void simbol7_Click(object sender, RoutedEventArgs e)//angka 7, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "7";
        }

        private void simbol8_Click(object sender, RoutedEventArgs e)//angka 8, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "8";
        }

        private void simbol9_Click(object sender, RoutedEventArgs e)//angka 9, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "9";
        }

        private void simbol0_Click(object sender, RoutedEventArgs e)//angka 0, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            labelOutput.Text = labelOutput.Text + "0";
        }

        private void simbolPlus_Click(object sender, RoutedEventArgs e)//simbol +, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            x = float.Parse(labelOutput.Text);
            labelOutput.Text = "";
            perulangan = 2;
        }

        private void simbolSamadengan_Click(object sender, RoutedEventArgs e)// simbol =, 1302200084-Ahmad Fadhil Aulia Faisal
        {
            plus(perulangan);
        }

        private void labelOutput_TextChanged(object sender, TextChangedEventArgs e)// output hasil, 1302200084-Ahmad Fadhil Aulia Faisal
        {

        }

        public void plus(int count) // fungsi pertambahan
        {
            rumus = x + float.Parse(labelOutput.Text);
            labelOutput.Text = rumus.ToString();
       
        }
    }
}
