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
    /// Логика взаимодействия для AddUserPage.xaml
    /// </summary>
    public partial class AddUserPage : Page
    {
        public AddUserPage()
        {
            InitializeComponent();
            PersonRoleCb.Items.Add("Пользователь");
            PersonRoleCb.Items.Add("Клиент");
            RoleCb.ItemsSource = App.db.userrole.ToList();
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            var Person = new person()
            {
                firstname = FirstNameTb.Text,   
                lastname = LastNameTb.Text,
                middlename = MiddleNameTb.Text,
                personrole = PersonRoleCb.SelectedItem.ToString(),
              
            };
            App.db.person.Add(Person);
            App.db.SaveChanges();
            if(PersonRoleCb.SelectedIndex == 1)
            {
                NavigationService.Navigate(new MenuPage());
            }
            else
            {
                var User = new user()
                {
                    login = LoginTb.Text,
                    password = PassTb.Text,
                    status = null,
                    userrole = RoleCb.SelectedItem as userrole,
                    person = Person,
                };
                App.db.user.Add(User);
                App.db.SaveChanges();
                NavigationService.Navigate(new UserPage());

            }
        }
    }
}
