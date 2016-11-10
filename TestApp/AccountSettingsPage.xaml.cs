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
    public partial class AccountSettingsPage : Page
    {
        public AccountSettingsPage()
        {
            InitializeComponent();
        }

        //change language
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "/changeLanguage.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //change favourite withdrawal
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "/changeFavouriteWithdrawal.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //changePIN
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "/changePIN.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //logout
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //back
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string url = "/basicOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
