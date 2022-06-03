using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Логика взаимодействия для Avtoru.xaml
    /// </summary>
    public partial class Avtoru : Page
    {
        public Avtoru()
        {
            InitializeComponent();
        }
        void Idei_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/nataliiabul");

        }
        void proger_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/top_sportorg");

        }
        void danya_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/daneren");

        }
        void denis_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/olmae");

        }
        void marina_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("https://vk.com/miablb");

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
