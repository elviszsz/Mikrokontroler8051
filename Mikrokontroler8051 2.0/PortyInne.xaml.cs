using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace Mikrokontroler8051_2._0
{
    public sealed partial class PortyInne : Page
    {
        public PortyInne()
        {
            this.InitializeComponent();

            rst_panel.Visibility = Visibility.Collapsed;
            vss_panel.Visibility = Visibility.Collapsed;
            psen_panel.Visibility = Visibility.Collapsed;
            ale_panel.Visibility = Visibility.Collapsed;
            ea_panel.Visibility = Visibility.Collapsed;
            vcc_panel.Visibility = Visibility.Collapsed;
        }

        private void rst_but_Click(object sender, RoutedEventArgs e)
        {
            if (rst_panel.Visibility == Visibility.Collapsed)
            {
                rst_panel.Visibility = Visibility.Visible;
            }
            else
            {
                rst_panel.Visibility = Visibility.Collapsed;
            }
        }

        private void vss_but_Click(object sender, RoutedEventArgs e)
        {
            if (vss_panel.Visibility == Visibility.Collapsed)
            {
                vss_panel.Visibility = Visibility.Visible;
            }
            else
            {
                vss_panel.Visibility = Visibility.Collapsed;
            }
        }

        private void psen_but_Click(object sender, RoutedEventArgs e)
        {
            if (psen_panel.Visibility == Visibility.Collapsed)
            {
                psen_panel.Visibility = Visibility.Visible;
            }
            else
            {
                psen_panel.Visibility = Visibility.Collapsed;
            }
        }

        private void ale_but_Click(object sender, RoutedEventArgs e)
        {
            if (ale_panel.Visibility == Visibility.Collapsed)
            {
                ale_panel.Visibility = Visibility.Visible;
            }
            else
            {
                ale_panel.Visibility = Visibility.Collapsed;
            }
        }

        private async void latch_but_Click(object sender, RoutedEventArgs e)
        {
            //Frame.Navigate(typeof(LATCH));

            var dialog = new MessageDialog("Strona w budowie.");
            dialog.Title = "Przepraszamy za utrudnienia.";
            dialog.Commands.Add(new UICommand { Label = "Zamknij.", Id = 0 });
            var res = await dialog.ShowAsync();

            if ((int)res.Id == 0) { }
        }

        private void ea_but_Click(object sender, RoutedEventArgs e)
        {
            if (ea_panel.Visibility == Visibility.Collapsed)
            {
                ea_panel.Visibility = Visibility.Visible;
            }
            else
            {
                ea_panel.Visibility = Visibility.Collapsed;
            }
        }

        private void vcc_but_Click(object sender, RoutedEventArgs e)
        {
            if (vcc_panel.Visibility == Visibility.Collapsed)
            {
                vcc_panel.Visibility = Visibility.Visible;
            }
            else
            {
                vcc_panel.Visibility = Visibility.Collapsed;
            }
        }
    }
}
