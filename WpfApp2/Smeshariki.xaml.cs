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
    /// Логика взаимодействия для Smeshariki.xaml
    /// </summary>
    public partial class Smeshariki : Page
    {
        public Smeshariki()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new GameMenu());
        }

        private void Check(object sender, RoutedEventArgs e)
        {
            if (TexT.Text == "Крош" || TexT.Text == "крош")
                NavigationService.Navigate(new Smeshariki2());
            else
                MessageBox.Show("Вы ввели не верное слово!");
        }

        int count = 3;

        private void Help(object sender, RoutedEventArgs e)
        {

            if (count == 3)
            {
                count -= 1;
                MessageBox.Show($"Загаданный персонаж любит прыгать!Оставшиееся количество подсказок -  {count} ");
                
            }
            else if (count == 2)
            {
                count -= 1;
                MessageBox.Show($"Загаданный персонаж любит морковку!Оставшиееся количество подсказок -  {count}  ");
            }
            else if (count == 1)
            {
                count -= 1;
                MessageBox.Show($"Загаданный персонаж дружит с ежиком!Оставшиееся количество подсказок -  {count} ");
            }
            else if(count == 0) 
                MessageBox.Show($"У вас не осталось подсказок,если хотите получить доп.подсказку поставьте Нариману 5 :)");


        }

        private void skip2(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Smeshariki2());
        }
    }
}
