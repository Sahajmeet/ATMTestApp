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
    public partial class NumberPad : Page
    {
        public NumberPad(){
            InitializeComponent();
            String title;
    }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button theButton = sender as Button;
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Button theButton = sender as Button;
            string url = "/basicOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }

}
