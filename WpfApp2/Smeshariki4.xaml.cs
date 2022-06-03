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
    /// Логика взаимодействия для Smeshariki4.xaml
    /// </summary>
    public partial class Smeshariki4 : Page
    {
        public Smeshariki4()
        {
            InitializeComponent();
        }
        int count = 3;
        private void Help(object sender, RoutedEventArgs e)
        {
            if (count == 3)
            {
                count -= 1;
                MessageBox.Show($"Он учится петь!Оставшиееся количество подсказок -  {count} ");

            }
            else if (count == 2)
            {
                count -= 1;
                MessageBox.Show($"У него дома есть броня рыцаря !Оставшиееся количество подсказок -  {count}  ");
            }
            else if (count == 1)
            {
                count -= 1;
                MessageBox.Show($"Он бегает за Нюшей(без успешно) !Оставшиееся количество подсказок -  {count} ");
            }
            else if (count == 0)
                MessageBox.Show($"У вас не осталось подсказок,если хотите получить доп.подсказку поставьте Нариману 5 :)");
        }

        private void skip(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SmesharikiFinal());
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            if (TexT.Text == "Бараш" || TexT.Text == "бараш")
                NavigationService.Navigate(new SmesharikiFinal());
            else if (TexT.Text == "")
                MessageBox.Show("Вы не ввели слово!");
            else
                MessageBox.Show("Вы  ввели не верное слово!");
        }

        private void leave(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartGame());
        }
    }
}
