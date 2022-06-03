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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для final4.xaml
    /// </summary>
    public partial class final4 : Page
    {
        public final4()
        {
            InitializeComponent();
        }

        private void Avtotu(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Avtoru());
        }

        private void leave(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartGame());
        }

        private void lev(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GameMenu());
        }
    }
}
