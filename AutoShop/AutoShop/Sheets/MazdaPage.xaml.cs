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
    /// Логика взаимодействия для MazdaPage.xaml
    /// </summary>
    public partial class MazdaPage : Page
    {
        public MazdaPage()
        {
            InitializeComponent();
            using (var context = new UserRegistrationContext())
            {
                detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(c => c.CarId == 1).ToList();
            }
        }

        private void searchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var context = new UserRegistrationContext();
            detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(p => p.Name.Contains(searchTextBox.Text) && p.CarId == 1).ToList();
        }

        private void AddButton(object sender, RoutedEventArgs e)
        {

        }

        private void SorsComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var context = new UserRegistrationContext();

            if (SorsComboBox.SelectedIndex == 0)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(Name => Name.Car).Where(c => c.CarId == 1).ToList();
            }
            if (SorsComboBox.SelectedIndex == 1)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(c => c.Car).Where(c => c.CarId == 1).OrderBy(d => d.Price).ToList();
            }
            if (SorsComboBox.SelectedIndex == 2)
            {
                detailsItemsControl.ItemsSource = context.Details.Include(c => c.Car).Where(c => c.CarId == 1).OrderByDescending(d=>d.Price).ToList();

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var detail = (sender as Button)?.DataContext as Detail;
            Windows.BasketWindow updatePage = new Windows.BasketWindow(detail);
            updatePage.Show();
        }
    }
}
