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

namespace TestApp
{
    /// <summary>
    /// Interaction logic for numberPad.xaml
    /// </summary>
    public partial class NumberPadPIN : Page
    {
        public NumberPadPIN()
        {
            InitializeComponent();
        }

        public static string PIN { get; set; }
        public static int count { get; set; }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (PIN == "1234")
            {
                string url = "/basicOptions.xaml";
                NavigationService.Navigate(new Uri(url, UriKind.Relative));
            }
            else {
                PIN = "";
                count += 1;
            }

            if (count < 3)
            {
                label.Content = "Incorrect PIN, please try again.";
                PIN = "";
                tb.Text = "";
            }
            else
            {
                string url = "/lockedAccount.xaml";
                NavigationService.Navigate(new Uri(url, UriKind.Relative));
            }
        }

        //number 1
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            PIN += "1";
            tb.Text += "*";

        }

        //2 
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            PIN += "2";
            tb.Text += "*";
        }


        //3
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            PIN += "3";
            tb.Text += "*";
        }

        //4
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            PIN += "4";
            tb.Text += "*";
        }

        //5
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            PIN += "5";
            tb.Text += "*";
        }

        //6
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            PIN += "6";
            tb.Text += "*";
        }

        //7
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            PIN += "7";
            tb.Text += "*";
        }

        //8
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            PIN += "8";
            tb.Text += "*";
        }

        //9
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            PIN += "9";
            tb.Text += "*";
        }

        //0
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            PIN += "0";
            tb.Text += "*";
        }

        //backspace button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length >= 1)
            {
                tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
                PIN = PIN.Substring(0, PIN.Length - 1);
            }
        }

    }

}
