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
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
            Refresh();
        }
        private void Refresh()
        {
            ListOrder.ItemsSource = App.db.order.ToList();
        }

        private void FixBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная функция в разработке");

        }

        private void AddOrderBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Данная функция в разработке");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();

        }
    }
}
