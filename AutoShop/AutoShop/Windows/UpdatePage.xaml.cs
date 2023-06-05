using AutoShop.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace AutoShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для UpdatePage.xaml
    /// </summary>
    public partial class UpdatePage : Window
    {
        public Detail Detail { get; set; }
        public List<Car> Cars { get; set; }
        
        public UpdatePage(Detail detail)
        {
            Detail = detail;
            Cars= Session.Instance.Context.Cars.ToList();
            InitializeComponent();
            DataContext = null;
            DataContext = this;
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
            this.Close();
        }

        private void Updatebutton(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DetailName.Text == null || ModelCar.Text == null || YearofreleaseCar.Text == null || price.Text == null || Count.Text == null || CarSelected.SelectedIndex == null)
                {
                    MessageBox.Show("Поля пустые", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    if (Detail.NameId == 0)
                    {
                        Session.Instance.Context.Add(Detail);

                    }
                    else
                    {
                        Session.Instance.Context.Entry(Detail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    }
                    try
                    {
                        Session.Instance.Context.SaveChanges();
                        MessageBox.Show("Данные сохранены");
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                        Session.Instance.Context.Remove(Detail);
                    }
                }

                
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void UpdatePhoto(object sender, RoutedEventArgs e)
        {
            try
            {

                var dialog = new OpenFileDialog
                {

                };
                var result = dialog.ShowDialog();
                if (result != true)
                {
                    return;
                }
                string newFileName = Guid.NewGuid().ToString().Replace("-", "");
                string pathToCopy = $"image/{newFileName}";
                try
                {
                    File.Copy(dialog.FileName, pathToCopy);
                    Detail.PathImage = newFileName;
                }
                catch
                {
                    MessageBox.Show("Произошла ошибка в пути файла", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void limiterText(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid(((TextBox)sender).Text + e.Text);
        }
        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i) && i > 0 && i <= 2023;
        }

        private void Count_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid2(((TextBox)sender).Text + e.Text);
        }
        public static bool IsValid2(string str)
        {
            int i;
            return int.TryParse(str, out i) && i > 0 && i <= 100;
        }

        private void price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid3(((TextBox)sender).Text + e.Text);
        }
        public static bool IsValid3(string str)
        {
            int i;
            return int.TryParse(str, out i) && i > 0 && i <= 500000;
        }
    }
}
