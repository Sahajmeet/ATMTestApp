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
    public partial class NumberPadFavWithdrawal : Page
    {
        public NumberPadFavWithdrawal(){
            InitializeComponent();
    }
        public static int amount { get; set; }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        // submit
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "/confirmationPage.xaml";
            //+ "parameter=" + amount.ToString();
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //number 1
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tb.Text += "1";
        }

        //2 
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tb.Text += "2";
        }


        //3
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            tb.Text += "3";
        }

        //4
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            tb.Text += "4";
        }

        //5
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            tb.Text += "5";
        }

        //6
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            tb.Text += "6";
        }

        //7
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            tb.Text += "7";
        }

        //8
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            tb.Text += "8";
        }

        //9
        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            tb.Text += "9";
        }

        //0
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            tb.Text += "0";
        }

        //backspace button
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (tb.Text.Length >= 1) 
            tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
            
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            tb.Text += ".";
        }
    }

}
