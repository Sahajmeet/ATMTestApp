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
    /// Interaction logic for billSelector.xaml
    /// </summary>
    public partial class billSelector : Page
    {

        public billSelector()
        {
            InitializeComponent();
        }

        public static int runningTotal { get; set; }
        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            string url = "/confirmationPage.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //increment 10
        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label.Content.ToString()) < 10)
            {
                label.Content = Convert.ToString(Convert.ToInt16(label.Content.ToString()) + 1);
                runningTotal += 10 * Convert.ToInt16(label.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //decrement 10
        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label.Content.ToString()) > 0)
            {
                label.Content = Convert.ToString(Convert.ToInt16(label.Content.ToString()) - 1);
                runningTotal -= 10 * Convert.ToInt16(label.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //increment 20
        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label_Copy.ToString()) < 10)
            {
                label_Copy.Content = Convert.ToString(Convert.ToInt16(label_Copy.Content.ToString()) + 1);
                runningTotal += 20 * Convert.ToInt16(label_Copy.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //decrement 20
        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label_Copy.ToString()) > 0)
            {
                label_Copy.Content = Convert.ToString(Convert.ToInt16(label_Copy.Content.ToString()) - 1);
                runningTotal -= 20 * Convert.ToInt16(label_Copy.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //increment 50
        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label_Copy.ToString()) < 10)
            {
                label_Copy1.Content = Convert.ToString(Convert.ToInt16(label_Copy.Content.ToString()) + 1);
                runningTotal += 50 * Convert.ToInt16(label_Copy1.Content);
                label_Copy13.Content = runningTotal.ToString();
            }

        }

        //decrement 50
        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label_Copy.ToString()) > 0)
            {
                label_Copy1.Content = Convert.ToString(Convert.ToInt16(label_Copy.Content.ToString()) - 1);
                runningTotal -= 50 * Convert.ToInt16(label_Copy1.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //increment 100
        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt16(label_Copy.ToString()) < 10)
            {
                label_Copy2.Content = Convert.ToString(Convert.ToInt16(label_Copy.Content.ToString()) + 1);
                runningTotal += 100 * Convert.ToInt16(label_Copy2.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //decrement 100
        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {

            if (Convert.ToInt16(label_Copy.ToString()) > 0)
            {
                label_Copy2.Content = Convert.ToString(Convert.ToInt16(label_Copy.Content.ToString()) - 1);
                runningTotal -= 100 * Convert.ToInt16(label_Copy2.Content);
                label_Copy13.Content = runningTotal.ToString();
            }
        }

        //check colour
        private void totalCheck()
        {
            if (runningTotal != 500)
                label_Copy13.Foreground = Brushes.Red;
        }

        //back
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string url = "/basicOptions.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }

        //logout
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string url = "/MainWindow.xaml";
            NavigationService.Navigate(new Uri(url, UriKind.Relative));
        }
    }
}
