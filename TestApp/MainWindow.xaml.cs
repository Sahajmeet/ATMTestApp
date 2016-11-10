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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Page
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            string url = "/NumberPadAccount.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            string url = "/NumberPadPIN.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            string url = "/changeLanguage.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
