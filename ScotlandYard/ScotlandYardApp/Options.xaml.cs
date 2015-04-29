using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace ScotlandYardApp
{
    public partial class Page1 : PhoneApplicationPage
    {
        private TimeSpan interval = TimeSpan.FromMinutes(15);
        public Page1()
        {
            InitializeComponent();
            
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Slider.Value();
           interval = TimeSpan.FromMinutes(Convert.ToDouble(15));
        }

        private void OnNavigatedFrom(NavigationEventArgs e)
        {
            App thisApp = App.Current as App;
            thisApp.Interval = interval;

            base.OnNavigatedFrom(e);
        }

        private void OnNavigatedTo(NavigationEventArgs e)
        {
            App thisApp = App.Current as App;
            interval = thisApp.Interval;



            base.OnNavigatedTo(e);
        } 
    }
}