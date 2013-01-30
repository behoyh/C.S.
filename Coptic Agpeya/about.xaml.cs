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
using Coding4Fun.Phone.Controls;
using System.Windows.Media.Imaging;

namespace Coptic_Agpeya
{
    public partial class about : PhoneApplicationPage
    {
        public about()
        {
            InitializeComponent();
        }

        private void dialogbox(object sender, EventArgs e)
        {
            var messagePrompt = new MessagePrompt
            {
                Title = "             Change Text Size",  //white space needed to center text
            };

            messagePrompt.Completed += messagePrompt_Completed;

            RoundButton customButton = new RoundButton();
            customButton.ImageSource = new BitmapImage(new Uri("/icons/appbar.next.rest.png", UriKind.RelativeOrAbsolute));
            customButton.Click += new RoutedEventHandler(customButton_Click);
            messagePrompt.ActionPopUpButtons.Add(customButton);

            RoundButton customButton2 = new RoundButton();
            customButton2.ImageSource = new BitmapImage(new Uri("/icons/appbar.next.restup.png", UriKind.RelativeOrAbsolute));
            customButton2.Click += new RoutedEventHandler(customButton2_Click);
            messagePrompt.ActionPopUpButtons.Add(customButton2);

            messagePrompt.Show();
        }

        private void customButton2_Click(object sender, RoutedEventArgs e)
        {
            this.resizableGrid.Width += 10;
            this.resizableGrid.Height += 10;
        }

        private void messagePrompt_Completed(object sender, PopUpEventArgs<string, PopUpResult> e)
        {
           
        }
        void customButton_Click(object sender, RoutedEventArgs e)
        {
            this.resizableGrid.Width -= 10;
            this.resizableGrid.Height -= 10;
        }


       
    }
}