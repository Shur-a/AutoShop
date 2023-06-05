using AutoShop.Models;
using Microsoft.EntityFrameworkCore;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AutoShop.Sheets
{
    /// <summary>
    /// Логика взаимодействия для ToytaPage.xaml
    /// </summary>
    public partial class ToytaPage : Page
    {
        public ToytaPage()
        {
            InitializeComponent();
            using (var context = new UserRegistrationContext())
            {
                detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(c => c.CarId == 2).ToList();
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var context = new UserRegistrationContext();
            detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(p => p.Name.Contains(searchTextBox.Text) && p.CarId == 2).ToList();

        }

        private void SorsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var context = new UserRegistrationContext();

            if (SorsComboBox.SelectedIndex == 0)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(c => c.CarId == 2).ToList();
            }
            if (SorsComboBox.SelectedIndex == 1)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(c => c.Car).Where(c => c.CarId ==2).OrderBy(d => d.Price).ToList();
            }
            if (SorsComboBox.SelectedIndex == 2)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(c => c.Car).Where(c => c.CarId == 2).OrderByDescending(d => d.Price).ToList();

            }
        }

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            var service = (sender as Button)?.DataContext as Detail;
            if (service == null) return;

            var answer = MessageBox.Show("Вы уверены, что хотите удалить запись", "Подтверждение удаления",
                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (answer == MessageBoxResult.Yes)
            {
                try
                {
                    Session.Instance.Context.Details.Remove(service);
                    Session.Instance.Context.SaveChanges();
                    MessageBox.Show("Деталь удалена.", "Удаление успешно",
                        MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка при удалении!", "Ошибка",
                        MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void UpdateButton(object sender, RoutedEventArgs e)
        {
            var detail = (sender as Button)?.DataContext as Detail;
            Windows.UpdatePage updatePage = new Windows.UpdatePage(detail);
            updatePage.Show();
        }

        private void SendButton(object sender, RoutedEventArgs e)
        {
            var detail = (sender as Button)?.DataContext as Detail;
            Windows.BasketWindow Page = new Windows.BasketWindow(detail);
            Page.Show();
        }

        /*private void ModelComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var context = new UserRegistrationContext();
            if (ModelComboBox.SelectedIndex == 0)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(c => c.CarId == 2).ToList();
            }
            if (ModelComboBox.SelectedIndex == 1)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(n=>n.Car).Where(n=>n.ModelCar=="Mark2").ToList();
            }if (ModelComboBox.SelectedIndex == 3)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(n=>n.Car).Where(n=>n.ModelCar=="Supra").ToList();
            }if (ModelComboBox.SelectedIndex == 4)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(n=>n.Car).Where(n=>n.ModelCar=="Land Cruiser").ToList();
            }if (ModelComboBox.SelectedIndex == 5)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(n=>n.Car).Where(n=>n.ModelCar=="Crown").ToList();
            }if (ModelComboBox.SelectedIndex == 6)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(n=>n.Car).Where(n=>n.ModelCar=="Rav4").ToList();
            }if (ModelComboBox.SelectedIndex == 6)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(n => n.Car).Where(n => n.ModelCar == "Corolla").ToList();
            }
        }*/
    }
}
