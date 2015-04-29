using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ScotlandYardApp.Resources;
using System.Threading;
using System.Windows.Threading;



namespace ScotlandYardApp
{
    public partial class MainPage : PhoneApplicationPage
    {
        private TimeSpan interval = TimeSpan.FromSeconds(10);
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            
            // Sample code to localize the ApplicationBar
            BuildLocalizedApplicationBar();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = interval;
            timer.Start();
            timer.Tick += timer_Tick;
        }

        private void timer_Tick(object sender, object e)
        {
            MessageBox.Show("123");
        }


        private void appBarButtonText_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Options.xaml", UriKind.RelativeOrAbsolute));
        }

        private void appBarMenuItem_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Options.xaml", UriKind.RelativeOrAbsolute));
        }


        private void BuildLocalizedApplicationBar()
        {
            // Set the page's ApplicationBar to a new instance of ApplicationBar.
            ApplicationBar = new ApplicationBar();

            // Create a new button and set the text value to the localized string from AppResources.
            ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/feature.settings.png", UriKind.Relative));
            appBarButton.Text = AppResources.AppBarButtonText;
            ApplicationBar.Buttons.Add(appBarButton);
            appBarButton.Click += appBarButtonText_Click;


            // Create a new menu item with the localized string from AppResources.
            ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
            ApplicationBar.MenuItems.Add(appBarMenuItem);
            appBarMenuItem.Click += appBarMenuItem_Click;
        }
    }
}