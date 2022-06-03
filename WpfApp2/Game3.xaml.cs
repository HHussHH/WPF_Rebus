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
    /// Логика взаимодействия для Game3.xaml
    /// </summary>
    public partial class Game3 : Page
    {
        public Game3()
        {
            InitializeComponent();
        }

        private void skip(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Game4());
        }

        private void check(object sender, RoutedEventArgs e)
        {
            if (TexT.Text == "Скайрим" || TexT.Text == "скайрим")
                NavigationService.Navigate(new Game4());
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
                MessageBox.Show($"Игра в фентези стили.У вас осталлсь:{count} подсказок. ");

            }
            else if (count == 2)
            {
                count -= 1;
                MessageBox.Show($"Игра от создателей фаллаута.У вас осталлсь:{count} подсказок. ");
            }
            else if (count == 1)
            {
                count -= 1;
                MessageBox.Show($"Эта игра в открытом мире с драконами.У вас осталлсь:{count} подсказок.");
            }
            else if (count == 0)
                MessageBox.Show($"У вас не осталось подсказок,если хотите получить доп.подсказку поставьте Нариману 5 :)");
        }
    }
}
