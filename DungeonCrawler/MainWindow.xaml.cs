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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Dungeon(Combat)
        public static double health;
        public int turnCount = 1;
        public int oneTurn = 1;
        public int resetTurn = 0;
        public bool isDefending = false;
        public int enemyDmg = 10;
        public int playerDmg = 1;
        public double defensValue = 0;
        private string combatLog = "You dealt 1 dmg. Wauv you must feel good about yourself about now, huh.\n";
        private string defenseFailLog = "You tried to defend but failed. \n";
        private string exhaustionLog = "You are too exhausted (Too low stamina to do anything) \n)";
        // Hub
        public static int currency = 100;
        public static int potion;

        public MainWindow()
        {
            InitializeComponent();
            
            Currency.Content = "Gold: " + currency.ToString();
            PotionCounter.Content = "X " + potion.ToString();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Exit button
        {
            Close_Dungeon();
        }

        public void Attack_Click(object sender, RoutedEventArgs e) //Attack button
        {
           EnemyHealth1.Value -= playerDmg;
           TextBox.Text = combatLog;
           turnCount += oneTurn;
        }

        private void Defend_Click(object sender, RoutedEventArgs e)
        {
            if (turnCount == 1)
            {
                isDefending = true;
                defensValue = 0.25;
                turnCount += oneTurn;
            }
            else
            {
                TextBox.Text = defenseFailLog;
            }
        }

        private void EnemyHealth1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (isDefending == true && turnCount == 2)
            {
                HealthBar.Value -= enemyDmg * defensValue;
                isDefending = false;
                turnCount = resetTurn;
            }

            if (turnCount == 2 && isDefending == false)
            {
                HealthBar.Value -= enemyDmg;
                turnCount = resetTurn;
            }

        }

        private void HealthBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            health = HealthBar.Value;
        }

        private void Close_Dungeon()
        {
            EnemyHealth1.Visibility = Visibility.Hidden;
            TextBox.Visibility = Visibility.Hidden;
            ExitButton.Visibility = Visibility.Hidden;
            Attack.Visibility = Visibility.Hidden;
            Defend.Visibility = Visibility.Hidden;
            Spells.Visibility = Visibility.Hidden;
            Dungeon_Picture.Visibility = Visibility.Hidden;
            UI_Frame.Visibility = Visibility.Hidden;
            UI_Text.Visibility = Visibility.Hidden;
            Skeleton_Text.Visibility = Visibility.Hidden;
            Move_Out.Visibility = Visibility.Visible;


        }

        private void GoIntoDungeon()
        {
            EnemyHealth1.Visibility = Visibility.Visible;
            TextBox.Visibility = Visibility.Visible;
            ExitButton.Visibility = Visibility.Visible;
            Attack.Visibility = Visibility.Visible;
            Defend.Visibility = Visibility.Visible;
            Spells.Visibility = Visibility.Visible;
            Dungeon_Picture.Visibility = Visibility.Visible;
            UI_Frame.Visibility = Visibility.Visible;
            UI_Text.Visibility = Visibility.Visible;
            Skeleton_Text.Visibility = Visibility.Visible;
            Move_Out.Visibility = Visibility.Hidden;

        }
        //------------------------------------------------------------------------------Hub--------------------------------------------------------------------\\
        private void Eat_Click(object sender, RoutedEventArgs e)
        {
            HealthBar.Value += 20;
        }

        private void Shop_Click(object sender, RoutedEventArgs e)
        {
            ShowShop();
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
            Move_Out.Visibility = Visibility.Hidden;

        }

        //Hide shop window
        private void HideShop()
        {
            ShopWindow.Visibility = Visibility.Hidden;
            ExitShop.Visibility = Visibility.Hidden;
            BuyPotion.Visibility = Visibility.Hidden;
            BuyPotionText.Visibility = Visibility.Hidden;
            Move_Out.Visibility = Visibility.Visible;
        }

        private void Move_Out_Click(object sender, RoutedEventArgs e)
        {
            GoIntoDungeon();
        }
    }
}
