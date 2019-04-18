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

namespace DungeonCrawler
{
    /// <summary>
    /// Interaction logic for MainHub.xaml
    /// </summary>
    public partial class MainHub : Page
    {
        public static int currency;

        public MainHub()
        {
            InitializeComponent();
            HealthBar.Value = MainWindow.health;
            HealthBar.Value = 20;

            Currency.Content = "Gold: " + currency.ToString();
        }

        private void HealthBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void StaminaBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void Eat_Click(object sender, RoutedEventArgs e)
        {
            HealthBar.Value += 20;
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow.Visibility = Visibility.Visible;
        }

        private void MoveOut_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitShop_Click(object sender, RoutedEventArgs e)
        {
            ShopWindow.Visibility = Visibility.Hidden;
        }
    }
}
