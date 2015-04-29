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
        
        App thisApp = App.Current as App;
        public Page1()
        {
            InitializeComponent();
            txtBoxIntervalInMinutes.Text = Convert.ToString(thisApp.Interval);
            slider1.Value = thisApp.Interval.TotalMinutes;
            slider1.ValueChanged += Slider_ValueChanged;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            var slider = sender as Slider;
            thisApp.Interval = TimeSpan.FromMinutes(slider.Value);
            txtBoxIntervalInMinutes.Text = Convert.ToString(thisApp.Interval);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            //thisApp.Interval = interval;

            base.OnNavigatedFrom(e);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            //interval = thisApp.Interval;



            base.OnNavigatedTo(e);
        } 
    }
}