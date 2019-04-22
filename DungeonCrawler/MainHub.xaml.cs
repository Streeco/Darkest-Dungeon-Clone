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
        public static int currency = 100;
        public static int potion;

        public MainHub()
        {
            InitializeComponent();
            HealthBar.Value = MainWindow.health;

            Currency.Content = "Gold: " + currency.ToString();
            PotionCounter.Content = "X " + potion.ToString();
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
            ShowShop();
        }

        private void MoveOut_Click(object sender, RoutedEventArgs e) //When clicked move into dungeon "MainWindow.xaml"
        {
            
        }

        private void ExitShop_Click(object sender, RoutedEventArgs e)
        {
            HideShop();
        }

        private void BuyPotion_Click(object sender, RoutedEventArgs e)
        {
            if (currency >= 20)
            {
                potion++;
                currency -= 20;
                PotionCounter.Content = "X " + potion.ToString();
                Currency.Content = "Gold: " + currency.ToString();
            }
            
        }

        //Show shop window
        private void ShowShop()
        {
            ShopWindow.Visibility = Visibility.Visible;
            ExitShop.Visibility = Visibility.Visible;
            BuyPotion.Visibility = Visibility.Visible;
            BuyPotionText.Visibility = Visibility.Visible;
        }

        //Hide shop window
        private void HideShop()
        {
            ShopWindow.Visibility = Visibility.Hidden;
            ExitShop.Visibility = Visibility.Hidden;
            BuyPotion.Visibility = Visibility.Hidden;
            BuyPotionText.Visibility = Visibility.Hidden;
        }

    }
}
