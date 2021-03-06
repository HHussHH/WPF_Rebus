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
    /// Логика взаимодействия для Game1.xaml
    /// </summary>
    public partial class Game1 : Page
    {
        public Game1()
        {
            InitializeComponent();
        }

        private void skip(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Game2());
        }

        private void check(object sender, RoutedEventArgs e)
        {
            if (TexT.Text == "Ведьмак" || TexT.Text == "ведьмак")
                NavigationService.Navigate(new Game2());
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
                MessageBox.Show($"У таких как он желтые глаза.Подсказок осталось:{count} ");

            }
            else if (count == 2)
            {
                count -= 1;
                MessageBox.Show($"Они своего рода охотники.Подсказок осталось:{count}  ");
            }
            else if (count == 1)
            {
                count -= 1;
                MessageBox.Show($"Их глаза похожи на глаза кошек.Подсказок осталось:{count} ");
            }
            else if (count == 0)
                MessageBox.Show($"У вас не осталось подсказок,если хотите получить доп.подсказку поставьте Нариману 5 :)");
        }
    }
}
