using AutoShop.Sheets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using AutoShop.Models;

namespace AutoShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для InfoWindow.xaml
    /// </summary>
    public partial class InfoWindow : Window
    {
        public InfoWindow()
        {
            InitializeComponent();
           WindowState = WindowState.Maximized;
        }


        private void subaruClick(object sender, RoutedEventArgs e)
        {
            InfoPage infoPage = new InfoPage();
            mainFrame.Navigate(infoPage);
        }

        private void ChooseCar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChooseCar.SelectedIndex == 0)
            {
                MazdaPage mazdaPage = new MazdaPage();
                mainFrame.Navigate(mazdaPage);
            }
            if (ChooseCar.SelectedIndex == 1)
            {
                ToytaPage toytaPage = new ToytaPage();
                mainFrame.Navigate(toytaPage);
            }
            if (ChooseCar.SelectedIndex == 2)
            {
                InfoPage infoPage = new InfoPage();
                mainFrame.Navigate(infoPage);
            }
        }

        private void AddButoon(object sender, RoutedEventArgs e)
        {
            Windows.AddWindow addWindow = new Windows.AddWindow();
            addWindow.Show();
        }

        //private void mazdaButton(object sender, RoutedEventArgs e)
        //{
        //    MazdaPage mazdaPage = new MazdaPage();
        //    mainFrame.Navigate(mazdaPage);
        //}

        //private void ToyotaButtob(object sender, RoutedEventArgs e)
        //{
        //    ToytaPage toytaPage = new ToytaPage();
        //    mainFrame.Navigate(toytaPage);
        //}

        //private void SubaruButton(object sender, RoutedEventArgs e)
        //{
        //    InfoPage infoPage = new InfoPage();
        //    mainFrame.Navigate(infoPage);
        //}
    }
}
