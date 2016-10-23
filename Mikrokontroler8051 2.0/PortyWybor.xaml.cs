using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Mikrokontroler8051_2._0
{
    public sealed partial class PortyWybor : Page
    {
        public PortyWybor()
        {
            this.InitializeComponent();
        }

        private void portyglowne_but_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Porty0123));
        }

        private void portyinne_but_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PortyInne));
        }
    }
}
