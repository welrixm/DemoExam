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
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void AuthBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTb.Text.Trim();
            string password = PasswordTb.Password.Trim();

            if(login.Length == 0 && password.Length == 0)
            {
                MessageBox.Show("Пустые поля");
            }
            else
            {
                CurrentUser.AuthUser = App.db.user.ToList().Find(x=>x.login == login && x.password == password);
                if(CurrentUser.AuthUser == null)
                {
                    MessageBox.Show("Пользователя данного не существует");

                }
                else
                {
                    MessageBox.Show("Добро пожаловать");
                    NavigationService.Navigate(new MenuPage());
                }

            }
        }
    }
}
