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
    /// Interaction logic for deposit.xaml
    /// </summary>
    public partial class deposit : Page
    {
        public deposit()
        {
            InitializeComponent();
        }

        //amount
        private void button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "/NumberPadGeneral.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //back
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string url = "/basicOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //logout
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));

        }

        //submit
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string url = "/confirmationPage.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
