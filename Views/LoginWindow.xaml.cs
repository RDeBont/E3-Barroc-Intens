using E3_Barroc_Intens.Helpers;
using E3_Barroc_Intens.Models;
using E3_Barroc_Intens.Models.Enums;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Input;
using Windows.System;

namespace E3_Barroc_Intens.Views
{
    public sealed partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            TryLogin();
        }

        private void PasswordInput_KeyDown(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
            {
                TryLogin();
            }
        }

        private void UsernameInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            ErrorInfoBar.IsOpen = false;
        }

        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
            ErrorInfoBar.IsOpen = false;
        }

        private void TryLogin()
        {
            if (string.IsNullOrWhiteSpace(UsernameInput.Text) || string.IsNullOrEmpty(PasswordInput.Password))
            {
                ErrorInfoBar.IsOpen = true;
                return;
            }

            Session.Login(new Medewerker { Naam = "Beheerder", Rol = Rol.Admin });

            var mainWindow = new MainWindow();
            mainWindow.Activate();
            Close();
        }
    }
}