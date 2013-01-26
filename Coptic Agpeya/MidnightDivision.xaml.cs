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
    public partial class MidnightDivision : PhoneApplicationPage
    {
        public MidnightDivision()
        {
            InitializeComponent();
        }

        private void First_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/MidnightFirst.xaml", UriKind.Relative)); 
        }

        private void Second_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/MidnightSecond.xaml", UriKind.Relative)); 
        }

        private void Third_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Text/MidnightThird.xaml", UriKind.Relative)); 
        }
    }
}