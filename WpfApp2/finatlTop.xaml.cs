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
    /// Логика взаимодействия для finatlTop.xaml
    /// </summary>
    public partial class finatlTop : Page
    {
        public finatlTop()
        {
            InitializeComponent();

            AppContext db = new AppContext();
            List<User> users = db.Users.ToList();
            
            ListUser.ItemsSource = users;
            
        }

        private void back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StartGame());
        }
       
    }
}
