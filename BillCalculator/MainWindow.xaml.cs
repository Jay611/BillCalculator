using BillCalculator.Models;
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

namespace BillCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MenuViewModel menuViewModel;
        Order order = new Order();
        System.Windows.Data.CollectionViewSource orderDetail;
        System.Windows.Data.CollectionViewSource orderList;

        public MainWindow()
        {
            InitializeComponent();

            menuViewModel = new MenuViewModel(new SeedMenu());

            BeverageComboBox.ItemsSource = menuViewModel.BeverageFilter;
            AppetizerComboBox.ItemsSource = menuViewModel.AppetizerFilter;
            MainCourseComboBox.ItemsSource = menuViewModel.MainCourseFilter;
            DessertComboBox.ItemsSource = menuViewModel.DessertFilter;
        }

        private void OrderListDG_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            orderDetail = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderDetail")));
            orderList = ((System.Windows.Data.CollectionViewSource)(this.FindResource("orderList")));
            // Load data by setting the CollectionViewSource.Source property:
            orderDetail.Source = new List<Order>() { order };
            orderList.Source = order.Orders;

        }
        private bool handle = true;
        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            if(cmb.Text != "")
            {
                if (handle) Handle(cmb);
                handle = true;
            }

        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox cmb = sender as ComboBox;
            handle = !cmb.IsDropDownOpen;
            Handle(cmb);
        }
        private void Handle(ComboBox cmb)
        {
            order.AddItemToList(new OrderItem {Product = (Product)cmb.SelectedItem, Quantity = 1 });

            orderDetail.Source = new List<Order>() { order };
            orderList.Source = order.Orders;
        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            order.Orders.Clear();

            orderListDG.Items.Refresh();
            orderDetail.Source = new List<Order>() { order };

        }
        private void ButtonInvoice_Click(object sender, RoutedEventArgs e)
        {
            InvoiceWindow invoiceWindow = new InvoiceWindow(order);
            invoiceWindow.Show();

        }

        private void OrderListDG_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            order.OrderQuantityChange();
        }
    }
}
