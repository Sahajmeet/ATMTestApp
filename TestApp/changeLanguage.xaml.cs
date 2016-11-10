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
    /// Interaction logic for changeLanguage.xaml
    /// </summary>
    public partial class changeLanguage : Page
    {
        public changeLanguage()
        {

            InitializeComponent();
            if (string.IsNullOrEmpty(currentLanguage)) {
                label1.Content = "English";
            }
        }

        public static string currentLanguage { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "English";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            label1.Content = "Français";

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            label1.Content = "國語";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            label1.Content = "Español";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            label1.Content = "हिन्दी";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            label1.Content = "العَرَبِيَّة";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            currentLanguage = label1.Content.ToString();
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
