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
    /// Логика взаимодействия для reg.xaml
    /// </summary>
    public partial class reg : Page
    {
        AppContext db;
        public reg()
        {
            InitializeComponent();
            db = new AppContext();
         
 
        }

        private void register(object sender, RoutedEventArgs e)
        {
            string login = TextBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox_2.Password.Trim();
            string email = TextBoxEmail.Text.ToLower().Trim();

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
            else if (pass != pass_2)
            {
                passBox_2.ToolTip = "пароли отличаются!";
                passBox_2.Background = Brushes.Red;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                TextBoxEmail.ToolTip = "почта введена не корректно!";
                TextBoxEmail.Background = Brushes.Red;
            }

            else
            {
                TextBoxLogin.ToolTip = "";
                TextBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox_2.ToolTip = "";
                passBox_2.Background = Brushes.Transparent;
                TextBoxEmail.ToolTip = "";
                TextBoxEmail.Background = Brushes.Transparent;
                
                User user = new User(login, email, pass);
                
                NavigationService.Navigate(new Auth());
                db.Users.Add(user);
                db.SaveChanges();
            }
           


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Auth());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пишите вот сюда :) https://vk.com/top_sportorg ");
        }
    }
}
