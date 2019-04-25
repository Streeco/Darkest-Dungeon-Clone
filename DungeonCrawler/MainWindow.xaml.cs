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
using System.Data.Sql;

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
        public int skeletonDmg = 15;
        public int spiderDmg = 17;
        public int ghoulDmg = 30;
        public int playerDmg = 1;
        public int fsc = 15;
        private bool iceSpear = false;
        private bool earthQuake = false;
        private bool thunderStorm = false;
        private string combatLog = "You dealt 1 dmg. Wauv you must feel good about yourself about now, huh.\n";
        private string spellCastLog = "You dealt 3 dmg. WOOOAAAH THAT WAS EPIC!!! \n";
        private string OutOfManaLog = "You are out of mana, this could be troublesome... \n)";
        private string deathLog = "Too Bad... Knew you didn't had it in ya anyways, so just give up \n";
        // Hub
        public static int currency = 100;
        public static int potion;
        public static int ScoreBoard = 0;

        public MainWindow()
        {
            InitializeComponent();

            Currency.Content = "Gold: " + currency.ToString();
            PotionCounter.Content = "X " + potion.ToString();
            Score.Content = "Score = " + ScoreBoard.ToString();

            if (HealthBar.Value == 0)
            {
                TextBox.Text = deathLog;
            }

            if (Keyboard.IsKeyDown(Key.Escape))
            {
                ShowMenu();
            }
        }

        //Exit button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ShowMenu();
        }

        //Attack button
        public void Attack_Click(object sender, RoutedEventArgs e)
        {
            if (HealthBar.Value > 0)
            {
                if (SkeletonHealth.IsVisible)
                {
                    SkeletonHealth.Value -= playerDmg;
                    TextBox.Text = combatLog;
                    turnCount += oneTurn;
                }

                if (GiantSpiderHealth.IsVisible)
                {
                    GiantSpiderHealth.Value -= playerDmg;
                    TextBox.Text = combatLog;
                    turnCount += oneTurn;
                }

                if (GhoulHealth.IsVisible)
                {
                    GhoulHealth.Value -= playerDmg;
                    TextBox.Text = combatLog;
                    turnCount += oneTurn;
                }
            }

        }

        //Inventory(Items)
        private void Items_Click(object sender, RoutedEventArgs e)
        {

            if (Inventory.IsVisible)
            {
                Inventory.Visibility = Visibility.Hidden;
            }
            else
            {
                Inventory.Visibility = Visibility.Visible;
            }

        }

        private void PotionSwift_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PotionTough_Click(object sender, RoutedEventArgs e)
        {

        }

        private void PotionMana_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EscapeRope_Click(object sender, RoutedEventArgs e)
        {

        }

        //Spells
        private void Spells_Click(object sender, RoutedEventArgs e)
        {
            if (Spell_Menu1.IsVisible)
            {
                HideSpells();
            }
            else
            {
                ShowSpells();
            }


        }

        private void Icespear_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Earthquake_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ThunderStorm_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Fireball_Click(object sender, RoutedEventArgs e)
        {
            if (ManaBar.Value >= 15)
            {
                if (SkeletonHealth.IsVisible)
                {
                    SkeletonHealth.Value -= 3;
                    TextBox.Text = spellCastLog;
                    ManaBar.Value -= fsc;
                    HideSpells();
                }

                if (GiantSpiderHealth.IsVisible)
                {
                    GiantSpiderHealth.Value -= 3;
                    TextBox.Text = spellCastLog;
                    ManaBar.Value -= fsc;
                    HideSpells();
                }

                if (GhoulHealth.IsVisible)
                {
                    GhoulHealth.Value -= 3;
                    TextBox.Text = spellCastLog;
                    ManaBar.Value -= fsc;
                    HideSpells();
                }
            }
            else
            {
                TextBox.Text = OutOfManaLog;
            }
        }

        //Enemies
        private void SkeletonHealth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (turnCount == 2)
            {
                HealthBar.Value -= skeletonDmg;
                turnCount = resetTurn;
            }

            if (SkeletonHealth.Value <= 0)
            {
                SlainSkeleton();
                ScoreBoard++;
                currency += 2;
                Score.Content = "Score =" + ScoreBoard.ToString();
                Currency.Content = "Gold: " + currency.ToString();
            }

        }

        private void GiantSpider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (turnCount == 2)
            {
                HealthBar.Value -= spiderDmg;
                turnCount = resetTurn;
            }

            if (GiantSpiderHealth.Value <= 0)
            {
                SlainGiantSpider();
                ScoreBoard++;
                currency += 6;
                Score.Content = "Score =" + ScoreBoard.ToString();
                Currency.Content = "Gold: " + currency.ToString();
            }

        }

        private void GhoulHealth_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (turnCount == 3)
            {
                HealthBar.Value -= ghoulDmg;
                turnCount = resetTurn;
            }

            if (GhoulHealth.Value <=0)
            {
                ScoreBoard++;
                currency += 12;
                Score.Content = "Score =" + ScoreBoard.ToString();
                Currency.Content = "Gold: " + currency.ToString();
                GhoulMonster.Visibility = Visibility.Hidden;
            }
        }

        private void SlainSkeleton()
        {
            GiantSpiderHealth.Visibility = Visibility.Visible;
            GiantSpiderText.Visibility = Visibility.Visible;
            SkeletonHealth.Visibility = Visibility.Hidden;
            Skeleton_Text.Visibility = Visibility.Hidden;
            SkeletonMonster.Visibility = Visibility.Hidden;
            SpiderMonster.Visibility = Visibility.Visible;
        }

        private void SlainGiantSpider()
        {
            GhoulHealth.Visibility = Visibility.Visible;
            GhoulText.Visibility = Visibility.Visible;
            GiantSpiderHealth.Visibility = Visibility.Hidden;
            GiantSpiderText.Visibility = Visibility.Hidden;
            SpiderMonster.Visibility = Visibility.Hidden;
            GhoulMonster.Visibility = Visibility.Visible;
        }

        //Player
        private void HealthBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            health = HealthBar.Value;
            if (HealthBar.Value == 0)
            {
                TextBox.Text = deathLog;
            }
        }

        //Return to Hub
        private void Return_Button(object sender, RoutedEventArgs e)
        {
            Close_Dungeon();
        }



        //Hide dungeon window
        private void Close_Dungeon()
        {
            SkeletonHealth.Visibility = Visibility.Hidden;
            TextBox.Visibility = Visibility.Hidden;
            Attack.Visibility = Visibility.Hidden;
            Item.Visibility = Visibility.Hidden;
            Spells.Visibility = Visibility.Hidden;
            Dungeon_Picture.Visibility = Visibility.Hidden;
            UI_Frame.Visibility = Visibility.Hidden;
            UI_Text.Visibility = Visibility.Hidden;
            Skeleton_Text.Visibility = Visibility.Hidden;
            Return.Visibility = Visibility.Hidden;
            Move_Out.Visibility = Visibility.Visible;
            Eat.Visibility = Visibility.Visible;
            Spell_Menu1.Visibility = Visibility.Hidden;
            Spell_Menu2.Visibility = Visibility.Hidden;
            Fireball.Visibility = Visibility.Hidden;
            Icespear.Visibility = Visibility.Hidden;
            Earthquake.Visibility = Visibility.Hidden;
            ThunderStorm.Visibility = Visibility.Hidden;
            Inventory.Visibility = Visibility.Hidden;
            GhoulHealth.Visibility = Visibility.Hidden;
            GhoulText.Visibility = Visibility.Hidden;
            GiantSpiderHealth.Visibility = Visibility.Hidden;
            GiantSpiderText.Visibility = Visibility.Hidden;
            SkeletonMonster.Visibility = Visibility.Hidden;
        }

        //Show dungeon window
        private void GoIntoDungeon()
        {
            SkeletonHealth.Visibility = Visibility.Visible;
            TextBox.Visibility = Visibility.Visible;
            Attack.Visibility = Visibility.Visible;
            Item.Visibility = Visibility.Visible;
            Spells.Visibility = Visibility.Visible;
            Dungeon_Picture.Visibility = Visibility.Visible;
            UI_Frame.Visibility = Visibility.Visible;
            UI_Text.Visibility = Visibility.Visible;
            Skeleton_Text.Visibility = Visibility.Visible;
            Move_Out.Visibility = Visibility.Hidden;
            Return.Visibility = Visibility.Visible;
            SkeletonMonster.Visibility = Visibility.Visible;
        }

        //Show dungeon window
        private void ShowSpells()
        {
            Spell_Menu1.Visibility = Visibility.Visible;
            Spell_Menu2.Visibility = Visibility.Visible;
            Fireball.Visibility = Visibility.Visible;

            if (iceSpear == true)
            {
                Icespear.Visibility = Visibility.Visible;
            }
            if (earthQuake == true)
            {
                Earthquake.Visibility = Visibility.Visible;
            }
            if (thunderStorm == true)
            {
                ThunderStorm.Visibility = Visibility.Visible;
            }
        }

        //Show dungeon window
        private void HideSpells()
        {
            Spell_Menu1.Visibility = Visibility.Hidden;
            Spell_Menu2.Visibility = Visibility.Hidden;
            Fireball.Visibility = Visibility.Hidden;

            if (iceSpear == true)
            {
                Icespear.Visibility = Visibility.Hidden;
            }
            if (earthQuake == true)
            {
                Earthquake.Visibility = Visibility.Hidden;
            }
            if (thunderStorm == true)
            {
                ThunderStorm.Visibility = Visibility.Hidden;
            }
        }


        //------------------------------------------------------------------------------Hub--------------------------------------------------------------------\\
        private void Eat_Click(object sender, RoutedEventArgs e)
        {
            HealthBar.Value += 15;
            Eat.Visibility = Visibility.Hidden;
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

        private void Move_Out_Click(object sender, RoutedEventArgs e)
        {
            GoIntoDungeon();
        }

        private void Resume_Menu_Click(object sender, RoutedEventArgs e)
        {
            HideMenu();
        }

        private void Exit_Menu_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Potion_Click(object sender, RoutedEventArgs e)
        {
            if (potion > 0)
            {
                if (HealthBar.Value < 100)
                {
                    HealthBar.Value += 20;
                    potion--;
                    PotionCounter.Content = "X " + potion.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowMenu();
            HideOption();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            ShowOption();
        }

        //Show option window
        private void ShowOption()
        {
            Music_Option.Visibility = Visibility.Visible;
            Option.Visibility = Visibility.Visible;
            Text_Option.Visibility = Visibility.Visible;
            Sound_Option.Visibility = Visibility.Visible;
            Exit_Option.Visibility = Visibility.Visible;
            S_Slider.Visibility = Visibility.Visible;
            M_Slider.Visibility = Visibility.Visible;
        }

        //Hide option window
        private void HideOption()
        {
            //Hide Option
            Music_Option.Visibility = Visibility.Hidden;
            Option.Visibility = Visibility.Hidden;
            Text_Option.Visibility = Visibility.Hidden;
            Sound_Option.Visibility = Visibility.Hidden;
            Exit_Option.Visibility = Visibility.Hidden;
            S_Slider.Visibility = Visibility.Hidden;
            M_Slider.Visibility = Visibility.Hidden;
        }

        //Show menu Window
        private void ShowMenu()
        {
            //Show Menu
            Menu.Visibility = Visibility.Visible;
            Settings_Menu.Visibility = Visibility.Visible;
            Exit_Menu.Visibility = Visibility.Visible;
            Resume_Menu.Visibility = Visibility.Visible;
        }

        //Hide menu window
        private void HideMenu()
        {
            Menu.Visibility = Visibility.Hidden;
            Settings_Menu.Visibility = Visibility.Hidden;
            Exit_Menu.Visibility = Visibility.Hidden;
            Resume_Menu.Visibility = Visibility.Hidden;
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


        //----------------------------------------------------------MVC PATTERN-------------------------------------------------\\


    }
}
