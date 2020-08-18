using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace MyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Random ran = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClickExit(Object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        public string RNG()
        {
            int number = ran.Next(4, 24);
            string num = number.ToString();
            return num;
        }

        public string Rolling()
        {
            int number = ran.Next(1, 21);
            string num = number.ToString();
            return num;
        }

        private void StatRoll(Object sender, RoutedEventArgs e)
        {
            strength.Text = RNG();
            dexterity.Text = RNG();
            constitution.Text = RNG();
            intelligence.Text = RNG();
            wisdom.Text = RNG();
            charisma.Text = RNG();

        }
        private void Roll(Object sender, RoutedEventArgs e)
        {
            D20.Text = Rolling();
            if(D20.Text == "20")
            {
                D20.Text = "Natural 20!";
            }
            else if(D20.Text == "1")
            {
                D20.Text = "Natural 1...";
            }
        }
        private void Save(Object sender, RoutedEventArgs e)
        {
            Close();
        }
        
    }
}
