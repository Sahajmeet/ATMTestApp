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
    /// Interaction logic for transactionTypes.xaml
    /// </summary>
    public partial class transactionTypesStandard : Page
    {
        public transactionTypesStandard()
        {
            InitializeComponent();
        }

        //favourite withdrawal
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawalOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //deposit
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "/deposit.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //transfer
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string url = "/transferPage.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //withdrawal
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string url = "/withdrawals.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "/basicOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //logout
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
