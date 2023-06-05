using AutoShop.Models;
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

namespace AutoShop.Windows
{
    /// <summary>
    /// Логика взаимодействия для BasketWindow.xaml
    /// </summary>
    public partial class BasketWindow : Window
    {
        public Detail Detail{ get; set; }
        public List<Car> Cars { get; set; }
        public BasketWindow(Detail detail)
        {
            Detail = detail;
            Cars = Session.Instance.Context.Cars.ToList();
            InitializeComponent();
            DataContext = null;
            DataContext = this;
        }

        private void BackButton(object sender, RoutedEventArgs e)
        {
            Windows.InfoWindow infoWindow =new  Windows.InfoWindow();
            infoWindow.Show();
            this.Close();
        }

        private void Sendbutton(object sender, RoutedEventArgs e)
        {
            if (basketTextBox.Text == null || Convert.ToInt32(basketTextBox.Text) < 0)
            {
                MessageBox.Show("Данные неверны","Ошбика", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            MessageBox.Show($"Оформление заказа успешно завершенно.\nЗаказ придет через неделю\nДеталь на автомобиль {Detail.Car.Name} {Detail.ModelCar}\nДеталь {Detail.Name}\nКоличество {basketTextBox.Text}ш. ","Успешно",MessageBoxButton.OK);
            this.Close();
        }

        private void basketTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsValid(((TextBox)sender).Text + e.Text);
        }
        public static bool IsValid(string str)
        {
            int i;
            return int.TryParse(str, out i) && i > 0 && i <= 100;
        }
    }
}
