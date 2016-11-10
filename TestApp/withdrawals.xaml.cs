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
    /// Interaction logic for AccountSettingsPage.xaml
    /// </summary>
    public partial class Withdrawals : Page
    {
        public Withdrawals()
        {
            InitializeComponent();
        }

        //20
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //40
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //50
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //60
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //80
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //100
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //150
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //200
        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //other Amount
        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            string url = "/NumberPadWithdrawal.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //back
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string url = "/basicOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //logout
        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));

        }
    }
}
