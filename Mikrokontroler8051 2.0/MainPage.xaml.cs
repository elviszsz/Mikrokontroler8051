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
    public sealed partial class MainPage : Page
    {
        private string[] selectionItems = new string[] { "Definicja i Rodzina", "Architektura Intel 8051", "Porty P0, P1, P2, P3",
                                                         "Porty Inne", "Jednostka Arytmetyczno Logiczna Intel 8051",
                                                         "Rejestr specjalny PSW", "Pamięć danych Intel 8051",
                                                         "Blok rejestrów specjalnych SFR", "Rodzaje rejestrów specjalnych", "O mnie" };

        public MainPage()
        {
            this.InitializeComponent();

            split_view.IsPaneOpen = true;
        }

        private void hamburger_but_Click(object sender, RoutedEventArgs e)
        {
            split_view.IsPaneOpen = !split_view.IsPaneOpen;
        }

        private void back_but_Click(object sender, RoutedEventArgs e)
        {
            if (MyFrame.CanGoBack)
            {
                MyFrame.GoBack();
            }
        }

        //AUTOSUGGESTBOX
        private void autosuggestbox_TextChanged(AutoSuggestBox sender, AutoSuggestBoxTextChangedEventArgs args)
        {
            var autoSuggestBox = (AutoSuggestBox)sender;
            var filtered = selectionItems.Where(p => p.StartsWith(autoSuggestBox.Text)).ToArray();
            autoSuggestBox.ItemsSource = filtered;

            switch (autoSuggestBox.Text)
            {
                case "Definicja i Rodzina":
                    {
                        MyFrame.Navigate(typeof(DefinicjaRodzina));
                    }
                    break;
                case "Architektura Intel 8051":
                    {
                        MyFrame.Navigate(typeof(Architektura));
                    }
                    break;
                case "Porty P0, P1, P2, P3":
                    {
                        MyFrame.Navigate(typeof(Porty0123));
                    }
                    break;
                case "Porty Inne":
                    {
                        MyFrame.Navigate(typeof(PortyInne));
                    }
                    break;
                case "Jednostka Arytmetyczno Logiczna Intel 8051":
                    {
                        MyFrame.Navigate(typeof(JednostkaArtymetycznoLogiczna));
                    }
                    break;
                case "Pamięć danych Intel 8051":
                    {
                        MyFrame.Navigate(typeof(PamiecDanych));
                    }
                    break;
                case "O mnie":
                    {
                        MyFrame.Navigate(typeof(OMnie));
                    }
                    break;
                case "Rejestr specjalny PSW":
                    {
                        MyFrame.Navigate(typeof(RejestrSpecjalnyPSW));
                    }
                    break;
                case "Blok rejestrów specjalnych SFR":
                    {
                        MyFrame.Navigate(typeof(BlokRejestrowSpecjalnychSFR));
                    }
                    break;
                case "Rodzaje rejestrów specjalnych":
                    {
                        MyFrame.Navigate(typeof(RodzajeRejestrowSpecjalnych));
                    }
                    break;
            }
        }
        //AUTOSUGGESTBOX

        //HAMBURGER MENU
        private async void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (first_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(DefinicjaRodzina));
            }
            else if (second_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(Architektura));
            }
            else if (third_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(PortyWybor));
            }
            else if (fourth_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(JednostkaArtymetycznoLogiczna));
            }
            else if (fifth_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(PamiecDanych));
            }
            else if (sixth_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(RejestrSpecjalnyPSW));
            }
            else if (seventh_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(BlokRejestrowSpecjalnychSFR));
            }
            else if (help_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                var dialog = new MessageDialog("Przesuń palcem w lewo lub w prawo! Lub jeśli używasz aplikacji w wersji Desktopowej przy nagłówku powinny się pojawić strzałki do przesunięcia danego wątku.");
                dialog.Title = "W większości stron występuje nawigacja typu:";
                dialog.Commands.Add(new UICommand { Label = "Ok.", Id = 0 });
                var res = await dialog.ShowAsync();

                //if ((int)res.Id == 0)
            }
            else if (about_but.IsSelected)
            {
                if (split_view.IsPaneOpen)
                {
                    split_view.IsPaneOpen = false;
                }
                MyFrame.Navigate(typeof(OMnie));
            }
            else if (exit_but.IsSelected)
            {
                Application.Current.Exit();
            }
        }
        //HAMBURGER MENU
    }
}
