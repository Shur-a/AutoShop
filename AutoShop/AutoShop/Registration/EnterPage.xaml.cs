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
using AutoShop;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using AutoShop.Models;

namespace AutoShop.Registration
{
    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        UserRegistrationContext context = new UserRegistrationContext();
        public EnterPage()
        {
            InitializeComponent();
        }

        private void RegistBT_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Uri("Registration/RegistrationPage.xaml", UriKind.Relative));

        }

        private void SeePassword_Click(object sender, RoutedEventArgs e)
        {
    
        }

        private void NotSeePassword_Click(object sender, RoutedEventArgs e)
        {
            EnterPassword.Password = "*";
        }

        private void EnterBT_Click(object sender, RoutedEventArgs e)
        {
            var user = Session.Instance.Context.Authorizations.FirstOrDefault(u => u.Login == EnterLogin.Text && u.Password == EnterPassword.Password);

            if (user != null)
            {
                Windows.InfoWindow infoWindow = new Windows.InfoWindow();
                infoWindow.Show();
                
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }


        }
    }
}
