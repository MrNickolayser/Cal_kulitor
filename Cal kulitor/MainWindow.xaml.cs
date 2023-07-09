using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
using static System.Net.Mime.MediaTypeNames;

namespace Cal_kulitor
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string txt = "";
        public MainWindow()
        {
            InitializeComponent();
        }
       
        public void etm (string value)
        {
            txt += value;
            a.Text = txt;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            etm("1");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            etm("2");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            etm("3");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            etm("4");
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            etm("5");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            etm("6");
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            etm("7");
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            etm("8");
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            etm("9");
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            etm("0");
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            etm(" + ");
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            etm(" - ");
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            etm(" * ");
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            etm(" / ");
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            etm(".");
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            a.Text = "";
            txt = "";
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {

        }
        static string getString(char[] arr)
        {
            // string() is a used to 
            // convert the char array
            // to string
            string s = new string(arr);

            return s;
        }
        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            var b = txt.Length;
            if (b > 0)
            {
                char[] buffer = new char[b - 1];
                txt.CopyTo(0, buffer, 0, b - 1);
                txt = getString(buffer);
                a.Text = txt;
            }
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            etm("(");
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            etm(")");
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            etm(" % ");
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            etm(" ^ ");
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            etm(" ! ");
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {

        }
    }
}
