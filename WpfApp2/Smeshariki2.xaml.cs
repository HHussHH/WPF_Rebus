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
    /// Логика взаимодействия для Smeshariki2.xaml
    /// </summary>
    public partial class Smeshariki2 : Page
    {
        public Smeshariki2()
        {
            InitializeComponent();
        }

        private void skip(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Smeshariki3());
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            if (TexT.Text == "Нюша" || TexT.Text == "нюша")
                NavigationService.Navigate(new Smeshariki3());
            else if (TexT.Text == "")
                MessageBox.Show("Вы не ввели слово!");
            else
                MessageBox.Show("Вы  ввели не верное слово!");
        }

        private void leave(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartGame());
        }
        int count = 3;
        private void Help(object sender, RoutedEventArgs e)
        {
            if (count == 3)
            {
                count -= 1;
                MessageBox.Show($"мечтает о принце -  {count} ");

            }
            else if (count == 2)
            {
                count -= 1;
                MessageBox.Show($"любит кушать сладкое!Оставшиееся количество подсказок -  {count}  ");
            }
            else if (count == 1)
            {
                count -= 1;
                MessageBox.Show($"Крутит роман с барашем!Оставшиееся количество подсказок -  {count} ");
            }
            else if (count == 0)
                MessageBox.Show($"У вас не осталось подсказок,если хотите получить доп.подсказку поставьте Нариману 5 :)");
        }
    }
}

