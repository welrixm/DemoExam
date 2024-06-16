using Demo2024_Day3.Models;
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

namespace Demo2024_Day3.Pages
{
    /// <summary>
    /// Логика взаимодействия для UserPage.xaml
    /// </summary>
    public partial class UserPage : Page
    {
        public UserPage()
        {
            InitializeComponent();
            Refresh();
        }

        private void Refresh()
        {
            ListUser.ItemsSource = App.db.user.Where(x=>x.status == null).ToList();    
        }

        private void FixBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var SelUser = (sender as Button).DataContext as user;
                if(SelUser != null)
                {
                    SelUser.status = "уволен";
                    App.db.SaveChanges();
                    ListUser.ItemsSource = App.db.user.Where(x => x.status == null).ToList();

                }
            }
            catch { }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddUserPage());
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();

        }
    }
}
