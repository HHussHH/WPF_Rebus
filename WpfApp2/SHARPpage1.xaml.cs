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
    /// Логика взаимодействия для SHARPpage1.xaml
    /// </summary>
    public partial class SHARPpage1 : Page
    {
        public SHARPpage1()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("А вот на пары надо было ходить!У вас нет подсказок :)");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Cpage2());
        }

        private void check(object sender, RoutedEventArgs e)
        {

            if (TexT.Text == "Переменная" || TexT.Text == "переменная")
                NavigationService.Navigate(new Cpage2());
            else if (TexT.Text == "")
                MessageBox.Show("Вы не ввели слово!");
            else
                MessageBox.Show("Вы  ввели не верное слово!");

        }

        private void back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartGame());
        }
    }
}
