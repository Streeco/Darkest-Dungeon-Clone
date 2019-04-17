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
        private bool nextTurn;
        private string textLog = "You're attack was a success! Enemy took 1 dmg... \n Pathetic dmg but ok you have only just started";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //Exit button
        {
            Environment.Exit(0);
        }

        private void Attack_Click(object sender, RoutedEventArgs e)
        {
            HealthEnemy.Value -= 1;
            //UpdateText.Text
        }

      
    }
}
