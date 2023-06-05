using AutoShop.Models;
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
    /// Логика взаимодействия для AddWindow.xaml
    /// </summary>
    public partial class AddWindow : Window
    {
        private Detail Detail
        {
            get;
            set;
        }
        
        public AddWindow()
        {
            InitializeComponent();
            using(var context = new UserRegistrationContext())
            {
                CarSelected.ItemsSource=context.Cars.ToList();
            }
            Detail = new Detail();
        }

        private void Addbutton(object sender, RoutedEventArgs e)
        {
    
            if(Detail.NameId ==0)
            {
                if (DetailName.Text == null || ModelCar.Text == null || YearofreleaseCar.Text == null || price.Text == null || Count.Text == null || CarSelected.SelectedIndex == null)
                {
                    MessageBox.Show("Поля пустые", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    
                    Detail.Name = DetailName.Text;
                    Detail.ModelCar = ModelCar.Text;
                   
                    
                        Detail.YearofreleaseCar = YearofreleaseCar.Text;
                        Detail.Price = Convert.ToInt32(price.Text);
                        Detail.Count = Convert.ToInt32(Count.Text);
                    
                    Detail.CarId = CarSelected.SelectedIndex + 1;
                    Session.Instance.Context.Add(Detail);
                    Session.Instance.Context.SaveChanges();
                    MessageBox.Show("Товар добавлен");
                    this.Close();
                }
            }
                
            
        }

        private void addfoto(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFile = new Microsoft.Win32.OpenFileDialog();
            if(openFile.ShowDialog() == true )
            {
                var newPhoto = System.IO.Path.GetRandomFileName();
                var selected = openFile.FileName;
                var newPhotoFull = System.IO.Path.Combine(Environment.CurrentDirectory, "image", newPhoto);

                File.Copy(selected, newPhotoFull);
                Detail.PathImage = newPhotoFull;

                DataContext = null;
                DataContext = Detail;
            }
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            Windows.InfoWindow infoWindow = new InfoWindow();
            infoWindow.Show();
            this.Close();
        }

        private void YearofreleaseCar_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid(((TextBox)sender).Text + e.Text);
        }
        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i) && i >0 && i <= 2025;
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
