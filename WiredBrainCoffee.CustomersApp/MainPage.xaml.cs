using System;
using System.Linq;
using Windows.ApplicationModel;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WiredBrainCoffee.CustomersApp.DataProvider;
using WiredBrainCoffee.CustomersApp.Model;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary> 
    public sealed partial class MainPage : Page
    {
        public CustomerDataProvider _customerDataProvider { get; }

        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            App.Current.Suspending += App_Suspending;
            _customerDataProvider = new CustomerDataProvider();
        }



        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            customerListView.Items.Clear();
            var customers = await _customerDataProvider.LoadCustomersAsync();

            foreach (var customer in customers)
            {
                customerListView.Items.Add(customer);
            }
        }

        private async void App_Suspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();
            await _customerDataProvider.SaveCustomersAsync(
                customerListView.Items.OfType<Customer>());

            deferral.Complete();
        }

        private void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var customer = new Customer { FirstName = "New " };
            customerListView.Items.Add(customer);
            customerListView.SelectedItem = customer;
        }

        private void ButtonDeleteCustomer_Click(object sender, RoutedEventArgs e)
        {
            var customer = customerListView.SelectedItem as Customer;

            customerListView.Items.Remove(customer);                      
        }

        private void ButtonMove_Click(object sender, RoutedEventArgs e)
        {
            int column = (int)customerListGrid.GetValue(Grid.ColumnProperty);
            int newColumns = column == 0 ? 2 : 0;

            moveSymbolIcon.Symbol = newColumns == 0 ? Symbol.Forward : Symbol.Back;
            customerListGrid.SetValue(Grid.ColumnProperty, newColumns);
        }

        private void CustomerListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var customer = customerListView.SelectedItem as Customer;

            customerDetailControl.Customer = customer;
        }

       
    }
}
