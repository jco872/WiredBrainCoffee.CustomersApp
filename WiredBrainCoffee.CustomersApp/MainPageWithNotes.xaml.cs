﻿using System;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WiredBrainCoffee.CustomersApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPageWithNotes : Page
    {
        public MainPageWithNotes()
        {
            this.InitializeComponent();
        }

        private async void ButtonAddCustomer_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Customer Added!");
            var x = await messageDialog.ShowAsync();
        }
    }
}
