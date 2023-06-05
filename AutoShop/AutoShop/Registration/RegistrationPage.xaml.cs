using Microsoft.Data.SqlClient;
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
using Microsoft.EntityFrameworkCore;
using AutoShop.Models;


namespace AutoShop.Registration
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        UserRegistrationContext context = new UserRegistrationContext();
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void RegisBT_Click(object sender, RoutedEventArgs e)
        {
            var login = EnterLogin.Text;
            var password = EnterPassword.Password;


            // TODO: проверка полей

            var u = Session.Instance.Context.Authorizations.FirstOrDefault(u => u.Login == login);

            if (u != null)
            {
                MessageBox.Show("Пользователь с таким именем уже существует!");
                return;
            }


            Authorization user = new Authorization
            {
                Login = login,
                Password = password
            };

            try
            {
                Session.Instance.Context.Authorizations.Add(user);
                Session.Instance.Context.SaveChanges();

                Windows.InfoWindow infoWindow = new Windows.InfoWindow();
                infoWindow.Show();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении пользователя","Ошибка", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration/EnterPage.xaml", UriKind.Relative));
        }
    }
}
