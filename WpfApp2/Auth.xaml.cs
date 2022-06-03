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
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void auth(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
           

            if (login.Length < 5)
            {
                TextBoxLogin.ToolTip = "Логин слишком маленький";
                TextBoxLogin.Background = Brushes.Red;

            }
            else if (pass.Length < 5)
            {
                passBox.ToolTip = "пароль слишком маленький";
                passBox.Background = Brushes.Red;
            }
            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                
                User authUser = null;
                using (AppContext db = new AppContext())
                {
                    authUser = db.Users.Where(b => b.login == login && b.pass == pass).FirstOrDefault();
                }
                if (authUser != null)
                    NavigationService.Navigate(new StartGame());
                else
                    MessageBox.Show("Введенные данные не корректы!");

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new reg());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пишите вот сюда :) https://vk.com/top_sportorg ");
        }
    }
}
