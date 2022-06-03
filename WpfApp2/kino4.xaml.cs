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
    /// Логика взаимодействия для kino4.xaml
    /// </summary>
    public partial class kino4 : Page
    {
        public kino4()
        {
            InitializeComponent();
        }

        private void skip(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new final3());
        }

        private void check(object sender, RoutedEventArgs e)
        {
            if (TexT.Text == "Шерлок" || TexT.Text == "шерлок")
                NavigationService.Navigate(new final3()) ;
            else if (TexT.Text == "")
                MessageBox.Show("Вы не ввели слово!");
            else
                MessageBox.Show("Вы  ввели не верное слово!");
        }

        private void back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartGame());
        }

        int count = 3;
        private void help(object sender, RoutedEventArgs e)
        {
            if (count == 3)
            {
                count -= 1;
                MessageBox.Show($"Фильм с глубоким смыслом.Подсказок осталось:{count} ");

            }
            else if (count == 2)
            {
                count -= 1;
                MessageBox.Show($"Фильм снят по книгам.Подсказок осталось:{count}  ");
            }
            else if (count == 1)
            {
                count -= 1;
                MessageBox.Show($"Фильм снят в жанре детектив.Подсказок осталось:{count} ");
            }
            else if (count == 0)
                MessageBox.Show($"У вас не осталось подсказок,если хотите получить доп.подсказку поставьте Нариману 5 :)");
        }
    }
}
