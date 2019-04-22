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

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Defend_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Eat_Click(object sender, RoutedEventArgs e)
        {

        }

        private void HealthBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }

        private void StaminaBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

        }
    }
    rivate void OnButtonKeyDown(object sender, KeyEventArgs e)
    {
        switch (e.Key)
        {
            case Key.Down:
                if (previousDirection != (int)MOVINGDIRECTION.UPWARDS)
                    direction = (int)MOVINGDIRECTION.DOWNWARDS;
                break;
            case Key.Up:
                if (previousDirection != (int)MOVINGDIRECTION.DOWNWARDS)
                    direction = (int)MOVINGDIRECTION.UPWARDS;
                break;
            case Key.Left:
                if (previousDirection != (int)MOVINGDIRECTION.TORIGHT)
                    direction = (int)MOVINGDIRECTION.TOLEFT;
                break;
            case Key.Right:
                if (previousDirection != (int)MOVINGDIRECTION.TOLEFT)
                    direction = (int)MOVINGDIRECTION.TORIGHT;
                break;
        }
        previousDirection = direction;

    }
}
