using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Coptic_Agpeya
{
    public partial class MainPage : PhoneApplicationPage
    {
       


        public MainPage()
        {
            InitializeComponent();

        }
    


 

        private void Prime_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MainPiv.xaml", UriKind.Relative)); 
        }

        private void Terce_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/Terce.xaml", UriKind.Relative)); 
        }

        private void Sext_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/Sext.xaml", UriKind.Relative)); 
        }

        private void None_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/None.xaml", UriKind.Relative)); 
        }

        private void Vespers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/Vespers.xaml", UriKind.Relative)); 
        }

        private void Compline_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/Compline.xaml", UriKind.Relative)); 
        }

        private void Midnight_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/MidnightDivision.xaml", UriKind.Relative)); 
        }

        private void Other_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/Prayers.xaml", UriKind.Relative)); 
        }

        private void About(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative)); 
        }

        private void Settings(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Settings.xaml", UriKind.Relative)); 
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {

        }


        private Color lightThemeBackground = Color.FromArgb(255, 255, 255, 255);
        private Color darkThemeBackground = Color.FromArgb(255, 0, 0, 0);
        SolidColorBrush backgroundBrush = Application.Current.Resources["PhoneBackgroundBrush"] as SolidColorBrush;
        String filepath = null;

        public String ImageSource()
        {

            if (backgroundBrush.Color == lightThemeBackground)
            {
                VisualStateManager.GoToState(this, "Light", false);
                lightThemeBackground = Color.FromArgb(127, 145, 245, 0);
                filepath = "prayinghands.png";
            }
            else
            {

                VisualStateManager.GoToState(this, "Dark", false);
                darkThemeBackground = Color.FromArgb(127, 145, 0, 0);
                filepath = "Candle.png";
            }
            return filepath;
        }

       
    }
}