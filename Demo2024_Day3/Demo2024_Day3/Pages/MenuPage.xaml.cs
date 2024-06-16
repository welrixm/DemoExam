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
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
            RoleTb.Text = CurrentUser.AuthUser.userrole.namerole;
            if(CurrentUser.AuthUser.userrole.userroleid == 1)
            {
                AdminStack.Visibility = Visibility.Visible;
                RieltorStack.Visibility = Visibility.Hidden;
                LawyerStack.Visibility = Visibility.Hidden;

            }
            if (CurrentUser.AuthUser.userrole.userroleid == 2)
            {
                AdminStack.Visibility = Visibility.Hidden;
                RieltorStack.Visibility = Visibility.Visible;
                LawyerStack.Visibility = Visibility.Hidden;

            }
            if (CurrentUser.AuthUser.userrole.userroleid == 3)
            {
                AdminStack.Visibility = Visibility.Hidden;
                RieltorStack.Visibility = Visibility.Hidden;
                LawyerStack.Visibility = Visibility.Visible;

            }
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new UserPage());   
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());

        }

        private void ShiftsBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ShiftPage());

        }

        private void OrdersRieltorBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());

        }

        private void OrdersLawyerBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new OrderPage());

        }
    }
}
