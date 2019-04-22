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

        public MainWindow()
        {
            InitializeComponent();

            health = HealthBar.Value;

            //Make game start in the mainhub page
            MainHub mh = new MainHub();
            this.Content = mh;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Exit button
        {
            Environment.Exit(0);
        }

        public void Attack_Click(object sender, RoutedEventArgs e) //Attack button
        {
            if (StaminaBar.Value > 0)
            {
                EnemyHealth1.Value -= playerDmg;
                StaminaBar.Value -= 10;
                TextBox.Text = combatLog;
                turnCount += oneTurn;
            }
            else
            {
                TextBox.Text = exhaustionLog;
            }
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

        private void Eat_Click(object sender, RoutedEventArgs e)
        {
            if (StaminaBar.Value < 100)
            {
                StaminaBar.Value += 10;
                turnCount += oneTurn;
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
    }
   
}
