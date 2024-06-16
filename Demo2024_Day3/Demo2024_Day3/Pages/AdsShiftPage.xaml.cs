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
    /// Логика взаимодействия для AdsShiftPage.xaml
    /// </summary>
    public partial class AdsShiftPage : Page
    {
        shift shift;
        IEnumerable<user> Users;
        public AdsShiftPage(shift shifts)
        {
            Users = App.db.user.ToList();   
            InitializeComponent();
            shift = shifts;
            DataContext = shift;
            ListUser.ItemsSource = App.db.user.Where(x=>x.status == null).ToList();
        }
      

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var SelUser = ListUser.SelectedItems;
                DateTime start = (DateTime)DateStartDp.SelectedDate;
                DateTime end = (DateTime)DateEndDp.SelectedDate;
                var Shift = new shift()
                {
                    datestart = start,
                    dateend = end,
                };
                App.db.shift.Add(Shift);
                App.db.SaveChanges();
                for (int i = 0; i < SelUser.Count;  i++)
                {
                    var UserList = new userlist()
                    {
                        userid = ((user)SelUser[i]).userid,
                        shift = Shift,

                    };
                    App.db.userlist.Add(UserList);
                    App.db.SaveChanges();
                    NavigationService.Navigate(new ShiftPage());
                }
                
            }
            catch { }
        }
    }
}
