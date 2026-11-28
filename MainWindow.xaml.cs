using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using E3_Barroc_Intens.Helpers;
using E3_Barroc_Intens.Models;
using E3_Barroc_Intens.Views;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace E3_Barroc_Intens
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private readonly List<Button> _menuButtons = new();

        public MainWindow()
        {
            InitializeComponent();
            ShowCurrentUser();

            SetMenu(new List<NavItem>
            {
                new("Accounts", typeof(PlaceholderPage)),
                new("Klanten & prospects", typeof(PlaceholderPage)),
                new("Producten & voorraad", typeof(PlaceholderPage))
            });
        }

        public void SetMenu(IEnumerable<NavItem> items)
        {
            MenuPanel.Children.Clear();
            _menuButtons.Clear();

            foreach (NavItem item in items)
            {
                var button = new Button
                {
                    Content = item.Title,
                    Tag = item,
                    Style = (Style)Application.Current.Resources["MenuKnopStyle"]
                };
                button.Click += MenuButton_Click;

                MenuPanel.Children.Add(button);
                _menuButtons.Add(button);
            }

            if (_menuButtons.Count > 0)
            {
                OpenPage(_menuButtons[0]);
            }
        }

        private void MenuButton_Click(object sender, RoutedEventArgs e)
        {
            OpenPage((Button)sender);
        }

        private void OpenPage(Button selected)
        {
            var item = (NavItem)selected.Tag;
            detailFrame.Navigate(item.PageType, item.Title);

            foreach (Button button in _menuButtons)
            {
                string styleKey = button == selected ? "MenuKnopActiefStyle" : "MenuKnopStyle";
                button.Style = (Style)Application.Current.Resources[styleKey];
            }
        }

        private void ShowCurrentUser()
        {
            Medewerker? user = Session.CurrentUser;
            UserInfoText.Text = user == null ? string.Empty : $"{user.Naam} · {user.Rol}";
        }

        private void LogoutButton_Click(object sender, RoutedEventArgs e)
        {
            Session.Logout();

            Close();
        }
    }
}
